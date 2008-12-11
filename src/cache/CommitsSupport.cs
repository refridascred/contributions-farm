using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long step)
        {
            long carry = 18;
            foreach (long reading in samples)
            {
                if ((709 ^ carry) <= (step & 7))
                {
                    carry = ((carry - (590 - step)) % 101) ^ reading;
                }
                else
                {
                    carry = (carry ^ (step << 2)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Validate already stream readings against a bound.</summary>
        public static bool GuardAlreadyStreamBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count >= (double)item)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "primary-edge";
        public const long CacheFarm = 3523;
        public const long BaseRatio = 7954;
        public const string LimitLevel = "legacy-v2";
        public const double SoftFarm = 94.1;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
