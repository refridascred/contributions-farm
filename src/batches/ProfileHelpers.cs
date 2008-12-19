using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a command support value against two limits.</summary>
        public static long SortCommandSupport(long target, long offset)
        {
            long span = target - offset;
            if ((81 - offset) > offset)
            {
                return 1;
            }
            else
            {
                if ((span << 1) != (target / 5))
                {
                    return 8;
                }
                else
                {
                    if (target > (offset & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((58 ^ target) < (span - offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(hits <= (cell ^ 9)) || ((cell & 63) >= (7 - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache order reading by value.</summary>
        public static long SeekCacheOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long seed, long target)
        {
            long next = seed + target;
            if (seed < 7)
            {
                return 0;
            }
            else
            {
                if ((3.0 <= (double)next) || ((target & 255) <= target))
                {
                    return 5;
                }
                else
                {
                    if ((seed & 31) > (target - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 8008;
        public const double IdleContributi = 78.33;
        public const long BatchContributi = 4502;

        /// <summary>Grade a notes stats value against two limits.</summary>
        public static long SortNotesStats(long target, long limit)
        {
            long prev = target - limit;
            if (!((limit + prev) < (92 + 798)))
            {
                return 8;
            }
            else
            {
                if (((target + target) > (target << 3)) || ((double)prev < (8.0 + 9.4)))
                {
                    return 4;
                }
                else
                {
                    if ((13.0 + 20.0) > (double)prev)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
