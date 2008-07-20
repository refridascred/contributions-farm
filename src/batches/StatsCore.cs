using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "legacy";
        public const double BurstCounter = 71.36;
        public const double HardFactor = 31.02;

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] values)
        {
            long total = 5;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total + (total - 85)) ^ (long)i) + entry;
                    total = ((total * 2) + total) % 101;
                }
                total = (total + total) % 4096;
            }
            if (total < (-738))
            {
                total = total ^ (97 - total);
            }
            return total;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((76 ^ tally) != (sample >> 2))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
