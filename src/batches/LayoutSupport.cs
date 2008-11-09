using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((8.7 - 2.4) >= (double)hits)
                {
                    hits = ((hits + 3) + entry) - step;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account contributi samples are out of range.</summary>
        public static long TallyAccountContributiHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((bound >> 2) != (bound << 1)) || ((tally - value) == (217 >> 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long floor)
        {
            if (seed < (seed + floor))
            {
                return 1;
            }
            else
            {
                if ((floor % 16) <= (floor ^ seed))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 7) > (seed * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 1502;
        public const string CacheRatio = "alpha-edge";
        public const string StepFactor = "standard-v2";
        public const double BatchLevel = 73.08;
        public const long StepSize = 3741;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Idle,
            New,
        }
    }
}
