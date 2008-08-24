using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
