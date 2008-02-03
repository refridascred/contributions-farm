using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                if ((((-424) & 63) > ((long)i * 5)) && ((step + acc) < acc))
                {
                    break;
                }
                else
                {
                    acc = acc ^ step;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long floor)
        {
            if (((5.0 / 9.0) == (double)floor) || (floor < (-21)))
            {
                return 4;
            }
            else
            {
                if (target >= (984 >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((target + floor) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long offset)
        {
            long span = seed + offset;
            if (span > (seed & 63))
            {
                return 6;
            }
            else
            {
                if ((span / 9) > seed)
                {
                    return 5;
                }
                else
                {
                    if ((13.0 + 0.63) == (double)span)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((12 ^ span) < 2)
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
}
