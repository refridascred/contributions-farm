using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values)
        {
            long acc = 5;
            foreach (long cell in values)
            {
                if ((double)acc > (6.1 * 9.76))
                {
                    acc = (acc * 4) + (8 + 552);
                }
                else
                {
                    acc = acc ^ cell;
                }
            }
            return acc;
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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample >= ((long)series.Length + sample))
                {
                    seen = (seen + 3) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
