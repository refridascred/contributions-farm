using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Synced,
            Pending,
            Stale,
            Closed,
            Queued,
        }

        /// <summary>Check that every record account entry stays within the limit.</summary>
        public static bool CheckRecordAccountBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                if ((mix & 7) != (mix >> 5))
                {
                    mix = (mix << 3) ^ (reading % 64);
                }
            }
            if (mix < 74)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 36.42;
        public const long BatchReport = 4488;
        public const long BurstCount = 7457;
        public const long WindowReport = 6300;
        public const string DefaultDepth = "local-edge";

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 16.26;
        public const long IdleChannel = 5475;
        public const long MaxChannel = 6431;
        public const string BatchDepth = "standard-1";
    }
}
