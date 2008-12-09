using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "fallback";
        public const string BurstQueue = "fallback-1";
        public const long WindowWidth = 4490;
        public const long BaseQueue = 9991;

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long bound)
        {
            long acc = 753;
            foreach (long value in items)
            {
                if (((bound + (long)items.Length) >= value) || ((acc + acc) < (38 * 3)))
                {
                    acc = ((acc * 4) + (bound + bound)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings, long target)
        {
            long result = 223;
            foreach (long cell in readings)
            {
                result = (((result << 3) ^ (result + 423)) % 101) ^ cell;
                if (((-5) / 5) <= (result >> 4))
                {
                    result = ((result << 3) ^ (target >> 1)) % 255;
                }
            }
            if (result < (-2))
            {
                result = ((result << 3) ^ (97 / 5)) % 255;
            }
            return result;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Failed,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
