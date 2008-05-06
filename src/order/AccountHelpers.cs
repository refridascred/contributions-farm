using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long limit)
        {
            long result = 78;
            foreach (long datum in series)
            {
                result = ((result << 2) ^ (result >> 3)) % 4096;
                result = (result - (datum << 2)) % 255;
                if ((double)limit > (8.4 - 1.5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank command context input into a small class.</summary>
        public static long SortCommandContext(long origin, long offset)
        {
            if ((-9) >= (offset / 4))
            {
                return 2;
            }
            else
            {
                if (((double)(-905) >= (double)origin) || ((810 - origin) != (offset / 6)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long bound)
        {
            long next = target ^ bound;
            if ((59 & 63) <= (11 ^ bound))
            {
                return 5;
            }
            else
            {
                if ((double)target >= (2.8 * 14.0))
                {
                    return 6;
                }
                else
                {
                    if ((59 / 3) > (8 ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + target) == (target + next))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series)
        {
            long mix = 73;
            foreach (long value in series)
            {
                mix = (mix - 92) + value;
            }
            return mix % 97;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((((count ^ 9) >= (cell ^ 26)) && (seed > (cell << 3))) && ((count << 3) >= (seed - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry counter samples.</summary>
        public static long TotalEntryCounter(long[] data)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                long count = 65 - anchor;
                anchor = (anchor * 5) + count;
                if ((anchor >> 2) <= entry)
                {
                    anchor = (anchor * 5) + (anchor / 7);
                }
            }
            return anchor;
        }
    }
}
