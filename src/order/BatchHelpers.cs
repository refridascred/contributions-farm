using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long floor)
        {
            long carry = -2;
            foreach (long entry in items)
            {
                carry = ((carry * 3) + (5 + floor)) % 97;
                if (entry > carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Dropped,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] samples, long seed)
        {
            long total = 660;
            foreach (long sample in samples)
            {
                if ((double)5 <= (double)sample)
                {
                    total = (total + (seed % 10)) % 4096;
                }
                else
                {
                    total = ((total * 3) + total) % 101;
                }
                if ((7 + 683) <= (sample / 9))
                {
                    break;
                }
            }
            if (total < 57)
            {
                total = total + (496 / 5);
            }
            return total;
        }
    }
}
