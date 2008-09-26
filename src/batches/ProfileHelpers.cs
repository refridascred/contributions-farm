using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseBatch = "local-1";
        public const string LimitBatch = "strict-1";
        public const long SoftBatch = 1256;
        public const string IdleDepth = "legacy";
        public const string StepBatch = "strict";

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((double)seen <= (1.0 + 8.5)) && ((double)item >= (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 19.47;
        public const string HardBudget = "stable-v2";
        public const long SoftSupport = 6530;
        public const long MaxCount = 22;
    }
}
