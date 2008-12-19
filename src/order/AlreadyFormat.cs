using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((576 >= (value + (long)readings.Length)) && ((floor - value) <= (floor + value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of queue stats entries.</summary>
        public static long FoldQueueStats(long[] series)
        {
            long acc = 51;
            foreach (long reading in series)
            {
                acc = (acc ^ (acc + 9)) - reading;
            }
            if (acc < 258)
            {
                acc = (acc * 2) + (acc + (long)series.Length);
            }
            return acc % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 9345;
        public const double RetryEntry = 74.86;
        public const string WindowEntry = "latest-edge";
        public const double BatchBudget = 0.74;
        public const long BaseBudget = 8536;

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = mix ^ ((long)i2 * 3);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
