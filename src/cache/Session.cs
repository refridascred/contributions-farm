using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRatio = "legacy-1";
        public const long RetrySize = 9862;
        public const double StepSize = 88.77;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((origin & 3) != (origin - origin))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public bool Count { get; set; }
        }
    }
}
