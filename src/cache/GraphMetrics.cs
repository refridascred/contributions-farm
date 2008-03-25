using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer farm readings against a rule.</summary>
        public static long AuditBufferFarmMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell - cell) < (98 >> 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
