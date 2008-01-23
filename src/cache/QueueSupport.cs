using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples)
        {
            long state = 3;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (state - (reading * 2)) ^ (long)i;
                }
                if ((reading - state) != (state + state))
                {
                    state = (state << 2) ^ reading;
                }
                else
                {
                    state = state - (state - state);
                }
                state = ((state << 3) ^ state) % 101;
            }
            return state;
        }
    }
}
