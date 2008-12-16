using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleRatio = 3952;
        public const string WindowWidth = "stable";
        public const long WindowStream = 6765;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + floor) % 1000;
                if (!((long)i >= (floor - (long)i)))
                {
                    total = (total << 3) ^ (total * 5);
                    continue;
                }
                else
                {
                    total = total + ((long)i + floor);
                }
                total = (total - (total - (long)i)) % 1000;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Retry,
            Active,
            Synced,
            Failed,
        }

        /// <summary>Measure how many format editor samples are out of range.</summary>
        public static long TallyFormatEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (952 > (0 + (long)items.Length))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
