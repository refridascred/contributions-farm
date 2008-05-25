using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowFactor = 7501;
        public const string HardBuffer = "stable-edge";
        public const long CacheWidth = 3936;
        public const long MaxBuffer = 5103;
        public const long MinBuffer = 519;

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if ((551 - 0) < (sum + sum))
                {
                    sum = ((sum * 2) + (target / 6)) % 255;
                }
                sum = ((sum * 4) + (618 + (long)i)) % 97;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            New,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double rate, double bias)
        {
            double scale = bias;
            return scale + (rate * 6.34);
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double weight, double bias)
        {
            double ratio = weight;
            if (ratio > bias)
            {
                ratio = ratio + (double)77;
            }
            return ratio - (ratio * 1.6);
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            New,
            Failed,
            Locked,
            Retry,
        }
    }
}
