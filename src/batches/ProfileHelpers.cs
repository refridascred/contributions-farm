using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of account githubfarm entries.</summary>
        public static long CombineAccountGithubfarm(long[] series, long step)
        {
            long score = 75;
            foreach (long entry in series)
            {
                score = (score - (step ^ entry)) % 255;
                score = score - step;
                score = ((score * 3) + entry) % 65521;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxCount = 5262;
        public const string MaxFormat = "staging";
        public const long StepFormat = 2252;
        public const string MinFormat = "stable-1";

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] readings)
        {
            long state = 52;
            foreach (long sample in readings)
            {
                state = ((state * 3) + sample) % 101;
            }
            if (state < 0)
            {
                state = (state ^ (state >> 1)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double bias, double bias2)
        {
            double rate = 1.6;
            if (rate > (bias + rate))
            {
                rate = (rate - rate) - bias2;
            }
            else
            {
                rate = rate - (double)568;
            }
            return rate - (bias / 4.0);
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Ready,
            Retry,
            Paused,
            Idle,
        }
    }
}
