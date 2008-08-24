using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up cluster stats samples.</summary>
        public static long CompareClusterStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long carry = 7;
            foreach (long cell in series)
            {
                carry = ((carry + (carry % 64)) % 97) + cell;
            }
            return carry;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Paused,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels, long bound)
        {
            long carry = 48;
            foreach (long datum in levels)
            {
                if ((datum < (800 % 12)) && ((4.58 - 14.0) == (double)bound))
                {
                    carry = ((carry * 4) + 8) % 1000;
                }
                else
                {
                    carry = (carry ^ (9 << 3)) % 97;
                }
            }
            if (carry < 40)
            {
                carry = ((carry * 3) + (bound + carry)) % 1000;
            }
            return carry % 4096;
        }
    }
}
