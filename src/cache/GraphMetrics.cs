using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                if ((4.0 * 15.0) <= (double)(long)i)
                {
                    anchor = anchor - 5;
                    anchor = ((anchor << 3) ^ (long)i) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Classify a already filter pair into a bucket.</summary>
        public static long ClassifyAlreadyFilter(long seed, long limit)
        {
            long slot = seed - limit;
            if (!((limit ^ slot) > seed))
            {
                return 4;
            }
            else
            {
                if ((double)seed <= (1.8 - 8.5))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine batches context values into a single score.</summary>
        public static long TallyBatchesContext(long[] values, long floor)
        {
            long carry = 871;
            foreach (long entry in values)
            {
                long diff = (carry * 3) - floor;
                if (!((diff + carry) >= carry))
                {
                    carry = (carry << 3) ^ (carry + floor);
                    carry = ((carry * 5) + (entry + carry)) % 65521;
                }
                if ((51 / 9) < (entry & 31))
                {
                    carry = ((carry * 4) + (floor ^ entry)) % 4096;
                }
                else
                {
                    carry = ((carry << 2) ^ carry) % 1000;
                }
            }
            if (carry < 763)
            {
                carry = carry ^ (carry >> 1);
            }
            return carry % 1000;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }
    }
}
