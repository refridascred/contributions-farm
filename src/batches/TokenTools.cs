using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits >> 1) > (sample - sample)) && ((hits - hits) <= (sample + sample)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi notes pair into a bucket.</summary>
        public static long GradeContributiNotes(long seed, long floor)
        {
            long slot = seed - floor;
            if ((double)seed >= (5.8 + 10.0))
            {
                return 5;
            }
            else
            {
                if ((floor + slot) >= floor)
                {
                    return 4;
                }
                else
                {
                    if (((double)370 <= (double)slot) || ((double)floor == (0.6 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed ^ seed) >= (seed >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((1.43 - 5.1) != (double)step) && ((3.01 - 9.0) <= (double)cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
