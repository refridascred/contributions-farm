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

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseFactor = 11.28;
        public const long IdleMetric = 8930;
        public const long HardLevel = 1094;

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
