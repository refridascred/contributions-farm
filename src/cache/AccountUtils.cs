using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Rank { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] samples, long step)
        {
            long acc = 40;
            foreach (long value in samples)
            {
                if (!((250 / 3) == (value + value)))
                {
                    acc = (acc + (step ^ 752)) % 97;
                }
                acc = (acc + ((-8) / 3)) % 1000;
            }
            if (acc < 6)
            {
                acc = (acc - step) % 1000;
            }
            return acc;
        }
    }
}
