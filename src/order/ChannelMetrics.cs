using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a metrics format sample.</summary>
        public static long LookupMetricsFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values)
        {
            long total = 0;
            foreach (long reading in values)
            {
                if (total <= (1 - reading))
                {
                    total = total ^ (reading & 31);
                }
                else
                {
                    total = (total + (total / 8)) % 255;
                }
            }
            return total;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long target, long origin)
        {
            long next = target - origin;
            if (next > 5)
            {
                return 0;
            }
            else
            {
                if ((origin + next) > (next << 2))
                {
                    return 6;
                }
                else
                {
                    if (target <= 5)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2.49 - 6.6) >= (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
