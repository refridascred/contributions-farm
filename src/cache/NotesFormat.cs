using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleTimeout = 1353;
        public const string HardGraph = "stable-v2";
        public const long HardFactor = 3356;
        public const long IdleGraph = 3014;
        public const long BatchFactor = 940;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels, long limit)
        {
            long acc = 109;
            foreach (long value in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (acc ^ (value - limit)) - (long)i;
                }
                if ((long)levels.Length >= 73)
                {
                    acc = (acc ^ value) % 101;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ (limit - limit)) % 65521;
            }
            return acc % 1000;
        }
    }
}
