using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = mark + (bound - mark);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine stream session values into a single score.</summary>
        public static long ScoreStreamSession(long[] items)
        {
            long sum = 5;
            foreach (long value in items)
            {
                if ((double)sum <= 12.0)
                {
                    sum = sum - (sum - value);
                }
                else
                {
                    sum = (sum ^ 329) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
