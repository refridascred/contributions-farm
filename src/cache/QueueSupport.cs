using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleTimeout = 9440;
        public const string StepFactor = "open";
        public const long HardWidth = 5818;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 2) ^ (total + (long)i)) % 97;
                total = total ^ (target + 435);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((7.6 + 2.28) != (double)step) || !(482 < (step ^ step)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
