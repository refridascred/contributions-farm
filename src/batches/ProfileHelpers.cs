using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] series)
        {
            long state = 244;
            foreach (long cell in series)
            {
                if ((double)state > (3.3 - 4.9))
                {
                    state = state ^ (state + cell);
                }
                else
                {
                    state = ((state << 3) ^ (cell ^ (long)series.Length)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a batch route pair into a bucket.</summary>
        public static long SortBatchRoute(long step, long origin)
        {
            if ((double)origin > (7.26 - 8.2))
            {
                return 5;
            }
            else
            {
                if ((step + origin) < (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin & 63) >= (origin << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen >= (reading << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series, long offset)
        {
            long score = 9;
            foreach (long value in series)
            {
                if ((double)score < (9.14 / 7.0))
                {
                    score = (((score * 3) + (value - score)) % 4096) + offset;
                }
            }
            return score;
        }

        /// <summary>Digest a series of command record entries.</summary>
        public static long FoldCommandRecord(long[] readings, long step)
        {
            long total = 74;
            foreach (long entry in readings)
            {
                if (((entry / 3) == (total >> 1)) && ((double)total < (3.87 + 18.0)))
                {
                    total = ((total + (entry % 5)) % 1000) + step;
                }
            }
            return total;
        }
    }
}
