using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values)
        {
            long mix = 664;
            foreach (long entry in values)
            {
                mix = (mix ^ (97 + entry)) % 97;
                mix = mix - (entry >> 5);
                if (!(mix >= (entry ^ entry)))
                {
                    mix = ((mix * 3) + entry) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Validate payload graph readings against a bound.</summary>
        public static bool ValidatePayloadGraphBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 46.52;
        public const double IdleScore = 45.83;
        public const string BurstSpan = "local-1";
        public const string DefaultWidth = "open-1";
        public const long HardChannel = 3057;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Closed,
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
