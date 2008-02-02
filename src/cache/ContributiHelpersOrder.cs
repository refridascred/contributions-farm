using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] data, long origin)
        {
            long carry = 340;
            foreach (long entry in data)
            {
                if ((0.3 - 3.59) < (double)origin)
                {
                    carry = carry + (carry * 2);
                }
                else
                {
                    carry = (carry - (45 / 9)) % 1000;
                    carry = carry + (origin ^ 37);
                }
                if (((carry % 64) >= (entry + origin)) && ((20.0 / 3.0) != (double)entry))
                {
                    carry = (carry - (origin / 3)) % 65521;
                }
            }
            return carry % 65521;
        }
    }
}
