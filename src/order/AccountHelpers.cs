using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of commits batches readings.</summary>
        public static long ScoreCommitsBatches(long[] readings, long step)
        {
            long carry = 110;
            foreach (long cell in readings)
            {
                carry = (((carry * 4) + carry) + cell) + step;
                carry = (carry ^ (856 * 4)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Classify a order command pair into a bucket.</summary>
        public static long RankOrderCommand(long offset, long target)
        {
            if ((136 >= (target >> 4)) && ((target + offset) != (539 - target)))
            {
                return 4;
            }
            else
            {
                if (((double)target == (13.0 - 10.0)) || ((target * 4) > (offset << 2)))
                {
                    return 6;
                }
                else
                {
                    if (!((2.0 * 2.32) < (6.63 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long step)
        {
            long prev = origin ^ step;
            if (!((9.28 * 5.9) < (double)origin))
            {
                return 2;
            }
            else
            {
                if ((double)step < (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((31 - prev) >= 141)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
