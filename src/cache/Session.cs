using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > origin)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels)
        {
            long score = -64;
            foreach (long datum in levels)
            {
                if ((6.0 * 14.0) < (double)datum)
                {
                    score = score - score;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long bound, long target)
        {
            if ((target / 2) != (target >> 1))
            {
                return 2;
            }
            else
            {
                if ((target - target) <= ((-597) << 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= 7.2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1.7 - 8.84) != (double)bound)
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

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSize = "open-1";
        public const long DefaultCount = 3076;
        public const long SoftBudget = 5748;
        public const double BurstSchema = 94.08;
    }
}
