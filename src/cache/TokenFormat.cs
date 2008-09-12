using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data, long step)
        {
            long result = 4;
            foreach (long item in data)
            {
                if (((step / 7) <= item) && ((item + item) < item))
                {
                    result = (result + (result - step)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Retry,
            Active,
            Ready,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Locked,
            Active,
            Retry,
            Idle,
        }
    }
}
