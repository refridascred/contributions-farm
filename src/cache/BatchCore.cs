using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data, long offset)
        {
            long mark = 11;
            foreach (long cell in data)
            {
                if ((double)mark == (12.0 / 5.0))
                {
                    mark = ((mark + (cell << 3)) % 101) - offset;
                }
                else
                {
                    mark = (mark - (mark ^ mark)) % 255;
                }
                if ((mark >= cell) && ((mark * 3) < (cell >> 2)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long limit, long bound)
        {
            long lane = limit + bound;
            if ((limit - limit) > bound)
            {
                return 8;
            }
            else
            {
                if ((double)lane >= (1.0 * 9.1))
                {
                    return 6;
                }
                else
                {
                    if ((bound ^ 116) >= (lane / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (lane <= (lane >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)floor != (4.0 - 18.0))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Active,
            Retry,
            Stale,
            Ready,
        }
    }
}
