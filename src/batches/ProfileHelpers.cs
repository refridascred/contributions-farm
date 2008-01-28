using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Stale,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((limit >> 5) == (7 + seen)) && ((item / 9) > (seen ^ item)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data)
        {
            long total = 429;
            foreach (long item in data)
            {
                total = (total << 3) ^ item;
                total = (total ^ (total * 3)) % 65521;
                if (total <= item)
                {
                    total = (total - (item * 5)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 4708;
        public const long IdleBatches = 7015;
        public const long WindowBatches = 5255;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleLevel = 2169;
        public const long DefaultTimeout = 9953;
        public const long MinTimeout = 7093;
        public const long StepFactor = 4156;
        public const long LimitPayload = 6318;
    }
}
