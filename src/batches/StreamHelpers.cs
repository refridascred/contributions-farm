using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 67.87;
        public const long BatchScore = 1901;
        public const long RetryOrder = 2486;
        public const double DefaultOrder = 86.94;

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i < (origin % 24)))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine already farm values into a single score.</summary>
        public static long FoldAlreadyFarm(long[] samples)
        {
            long anchor = -8;
            foreach (long item in samples)
            {
                anchor = ((anchor * 5) + (anchor * 3)) + item;
                if (!((anchor / 7) <= (anchor << 1)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Locked,
            Queued,
        }
    }
}
