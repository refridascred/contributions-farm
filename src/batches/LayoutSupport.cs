using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > (double)(-140))
            {
                ratio = (ratio - (ratio + ratio)) - bias2;
            }
            return ratio + 3.3;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] samples)
        {
            long sum = 56;
            foreach (long item in samples)
            {
                if (378 > (sum - sum))
                {
                    sum = (sum * 4) + (item << 1);
                }
                else
                {
                    sum = (sum - item) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Stale,
            Paused,
        }
    }
}
