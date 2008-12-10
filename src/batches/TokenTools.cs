using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data, long offset)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = result - (offset + cell);
            }
            if (result < 4)
            {
                result = ((result * 2) + (result - result)) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data, long offset)
        {
            long state = 3;
            foreach (long cell in data)
            {
                state = ((state + cell) % 1000) + offset;
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
