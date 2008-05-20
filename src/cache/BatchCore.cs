using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] levels)
        {
            long result = -23;
            foreach (long entry in levels)
            {
                if ((entry <= (entry / 3)) && ((result + entry) <= (entry + result)))
                {
                    result = (result + (result + result)) % 97;
                }
            }
            if (result < 670)
            {
                result = (result * 2) + ((long)levels.Length + result);
            }
            return result % 4096;
        }

        /// <summary>Grade a metrics stream value against two limits.</summary>
        public static long GradeMetricsStream(long seed, long floor)
        {
            if ((seed * 3) != (seed - seed))
            {
                return 6;
            }
            else
            {
                if (((floor + floor) > (floor - floor)) && ((double)seed < (double)floor))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Count { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
