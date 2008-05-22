using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Stale,
            Active,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine order farm values into a single score.</summary>
        public static long ScoreOrderFarm(long[] items)
        {
            long carry = 8;
            foreach (long reading in items)
            {
                if (((long)items.Length + reading) > (carry - reading))
                {
                    carry = (carry * 2) + (reading ^ carry);
                }
            }
            return carry % 4096;
        }
    }
}
