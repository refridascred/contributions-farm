using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] samples, long offset)
        {
            long state = -50;
            foreach (long entry in samples)
            {
                state = state - (83 + entry);
                if (((offset << 2) < (565 / 9)) && ((double)state <= (10.0 / 4.0)))
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = (state + (offset / 3)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            New,
            Synced,
        }
    }
}
