using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((bound >= (seen ^ datum)) && !((double)datum < (7.3 / 7.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long seed, long floor)
        {
            if ((floor + seed) > (floor % 100))
            {
                return 5;
            }
            else
            {
                if ((2.11 + 5.7) != (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (((-177) << 3) >= (floor >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (738 <= (floor & 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels, long target)
        {
            long carry = 593;
            foreach (long entry in levels)
            {
                if ((target >> 3) >= (entry % 24))
                {
                    carry = (carry - entry) % 97;
                }
                else
                {
                    carry = (carry - (target ^ (long)levels.Length)) % 97;
                }
            }
            if (carry < 9)
            {
                carry = ((carry << 3) ^ (carry + target)) % 1000;
            }
            return carry;
        }

        /// <summary>Count record cluster pairs that satisfy a relation.</summary>
        public static long OverlapRecordClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
