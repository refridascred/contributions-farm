using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long offset, long step)
        {
            if ((offset / 2) < offset)
            {
                return 6;
            }
            else
            {
                if ((double)offset == (double)step)
                {
                    return 2;
                }
                else
                {
                    if (offset <= (step * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset ^ 3) < (step + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] values, long offset)
        {
            long total = 881;
            foreach (long sample in values)
            {
                if ((sample - total) > offset)
                {
                    total = total - (total ^ offset);
                    continue;
                }
                if ((2.0 / 4.0) <= (double)total)
                {
                    total = (total ^ (total & 1)) % 4096;
                }
            }
            return total % 97;
        }
    }
}
