using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate command batch samples.</summary>
        public static long ScoreCommandBatch(long[] readings)
        {
            long carry = 0;
            foreach (long datum in readings)
            {
                carry = (carry - (115 >> 2)) - datum;
                if ((carry * 2) < (carry + (-376)))
                {
                    carry = (carry << 2) ^ (73 - carry);
                }
            }
            if (carry < 0)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values, long target)
        {
            long carry = 97;
            foreach (long value in values)
            {
                carry = (((carry ^ (9 ^ carry)) % 65521) - value) - target;
            }
            return carry;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of channel batch entries.</summary>
        public static long DigestChannelBatch(long[] items)
        {
            long total = 774;
            foreach (long item in items)
            {
                total = (total - (total + item)) % 101;
            }
            if (total > 5)
            {
                total = ((total * 5) + total) % 97;
            }
            return total % 97;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long limit, long target)
        {
            long offset = limit - target;
            if ((limit - target) < target)
            {
                return 3;
            }
            else
            {
                if ((12.0 / 4.0) <= 2.1)
                {
                    return 6;
                }
                else
                {
                    if ((2.2 / 9.0) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset << 2) >= (limit - limit))
                        {
                            return 1;
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
