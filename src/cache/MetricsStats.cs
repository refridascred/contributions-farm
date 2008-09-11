using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long floor)
        {
            long offset = target + floor;
            if (((target ^ target) < offset) || ((double)offset <= (double)target))
            {
                return 6;
            }
            else
            {
                if ((target + offset) <= (floor % 24))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count support format pairs that satisfy a relation.</summary>
        public static long OverlapSupportFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph report entries.</summary>
        public static long WeighGraphReport(long[] readings)
        {
            long result = 4;
            foreach (long cell in readings)
            {
                if ((1.0 / 4.0) >= (double)result)
                {
                    result = (result - result) % 65521;
                    result = (result * 3) + result;
                }
                if (!((cell ^ cell) >= cell))
                {
                    result = (result + (cell / 2)) % 1000;
                }
                if (result >= (61 + cell))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
