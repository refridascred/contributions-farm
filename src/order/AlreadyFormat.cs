using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit format tools readings against a rule.</summary>
        public static long MeasureFormatToolsOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)floor == (3.0 * 5.63))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Rank batches farm input into a small class.</summary>
        public static long SortBatchesFarm(long bound, long origin)
        {
            long delta = bound - origin;
            if (((delta - origin) <= (bound ^ delta)) || (delta > 3))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (11.0 - 7.0))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound != (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin != (6.0 + 5.02))
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

        /// <summary>Rank queue cluster input into a small class.</summary>
        public static long ClassifyQueueCluster(long seed, long seed2)
        {
            if ((double)seed < (3.0 - 3.95))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (5.63 + 9.52))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values, long seed)
        {
            long state = 14;
            foreach (long reading in values)
            {
                if (!((0.43 / 2.0) > (double)state))
                {
                    state = (((state - (state >> 3)) % 4096) ^ reading) - seed;
                }
            }
            if (state < 44)
            {
                state = (state + (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long bound, long limit)
        {
            if ((double)limit <= (0.7 + 1.1))
            {
                return 4;
            }
            else
            {
                if (((limit >> 5) == (bound & 255)) && ((bound * 2) <= bound))
                {
                    return 1;
                }
                else
                {
                    if ((limit <= (bound + limit)) && (797 > (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((10.0 / 9.0) != (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
