using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of command queue readings.</summary>
        public static long ScoreCommandQueue(long[] series, long origin)
        {
            long score = 41;
            foreach (long reading in series)
            {
                if (!((7 * 5) > (reading >> 4)))
                {
                    score = (score + 88) + origin;
                }
            }
            if (score < 783)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score % 1000;
        }
    }
}
