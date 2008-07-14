using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((limit + limit) == (count * 4))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double scale, double span)
        {
            double rate = scale;
            if (rate >= (3.4 + 12.0))
            {
                rate = rate - span;
            }
            else
            {
                rate = rate + (double)4;
            }
            return rate - (span - scale);
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long step, long seed)
        {
            long cur = step ^ seed;
            if ((double)seed != (8.3 * 1.6))
            {
                return 6;
            }
            else
            {
                if (16.0 >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if (((double)step <= (3.8 * 6.2)) || ((1 << 1) > (cur - cur)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((587 % 64) != (step & 1))
                        {
                            return 1;
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
