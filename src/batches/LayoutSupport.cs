using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) >= tally)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length != (hits >> 1))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long bound)
        {
            long slot = seed - bound;
            if ((8.44 + 12.0) != (double)seed)
            {
                return 0;
            }
            else
            {
                if ((bound >= (6 - bound)) && (bound > seed))
                {
                    return 5;
                }
                else
                {
                    if (((double)slot <= (double)seed) && ((bound - slot) == (bound + slot)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed - seed) != (3 ^ bound)) || ((bound / 5) > 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
