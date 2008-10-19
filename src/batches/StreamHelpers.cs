using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of cluster channel readings.</summary>
        public static long ScoreClusterChannel(long[] data)
        {
            long sum = 869;
            foreach (long cell in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    long matches = (667 * 4) - ((long)i & 127);
                    sum = (((sum << 3) ^ (matches & 15)) % 4096) + cell;
                }
                sum = (sum ^ (5 % 10)) % 255;
            }
            if (sum < 99)
            {
                sum = (sum - (sum % 16)) % 101;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 67.36;
        public const long MinEntry = 2605;
        public const double BatchEntry = 52.21;
        public const long RetryEntry = 8375;
        public const long SoftLevel = 2498;

        /// <summary>Locate a batches buffer reading by value.</summary>
        public static long FindBatchesBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Synced,
            New,
            Paused,
            Stale,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
