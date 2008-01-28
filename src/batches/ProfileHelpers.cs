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

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double scale, double floor)
        {
            double ratio = floor;
            if (ratio > (scale - scale))
            {
                ratio = ratio - (floor * 7.65);
            }
            else
            {
                ratio = ratio + floor;
            }
            return ratio + floor;
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

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
