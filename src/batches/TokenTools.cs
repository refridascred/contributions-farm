using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long state = 215;
            foreach (long cell in samples)
            {
                state = state + (cell - 76);
                state = ((state << 2) ^ (cell + cell)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
