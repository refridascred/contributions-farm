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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((1 - 964) > (value + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long seed, long floor)
        {
            if ((double)floor > (double)(-9))
            {
                return 6;
            }
            else
            {
                if ((13.0 / 3.0) != (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor - seed) <= (seed << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Idle,
            New,
        }
    }
}
