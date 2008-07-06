using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (19.0 <= (double)seen)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Classify a graph batches pair into a bucket.</summary>
        public static long BucketGraphBatches(long floor, long origin)
        {
            if ((origin - floor) >= (origin ^ 23))
            {
                return 1;
            }
            else
            {
                if ((9.83 + 9.0) == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ 491) >= (473 >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor << 1) == (52 + 463)) || ((5.43 * 9.3) != (double)origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
