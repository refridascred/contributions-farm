using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long target, long bound)
        {
            long step = target + bound;
            if ((double)target < (9.0 + 9.8))
            {
                return 6;
            }
            else
            {
                if ((bound + target) >= (step + target))
                {
                    return 7;
                }
                else
                {
                    if ((769 & 7) <= (target % 12))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((93 + step) != (target + step)) && ((double)target == (2.0 - 2.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double gain = (double)(461 / 2);
            if (gain >= (span / 8.0))
            {
                gain = gain - (bias / 8.0);
            }
            else
            {
                gain = gain - 8.0;
            }
            return gain + (double)504;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Locked,
            Paused,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Count { get; set; }
            public double Region { get; set; }
        }
    }
}
