using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long bound, long floor)
        {
            long cur = bound + floor;
            if ((cur / 3) <= cur)
            {
                return 2;
            }
            else
            {
                if ((double)cur > (6.0 * 7.4))
                {
                    return 0;
                }
                else
                {
                    if (((floor / 2) <= (bound ^ floor)) && (bound < (floor >> 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound < (floor >> 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (score + score)) % 65521;
                if (85 <= score)
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((((tally + 51) <= (entry + entry)) && ((double)entry >= (3.2 * 3.4))) && ((4.1 * 8.33) > (double)entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
