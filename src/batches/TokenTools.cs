using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample == (11.0 + 0.5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count - datum) != (count - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long step)
        {
            if ((bound + bound) == (bound & 3))
            {
                return 3;
            }
            else
            {
                if ((bound / 9) != (step + step))
                {
                    return 2;
                }
                else
                {
                    if (!(bound > (bound % 2)))
                    {
                        return 6;
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
