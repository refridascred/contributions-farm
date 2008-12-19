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

        /// <summary>Adjust a schema entry reading.</summary>
        public static double ScaleSchemaEntry(double rate, double span)
        {
            double rate2 = rate;
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - (span + span)) + (double)(long)i;
            }
            return rate2 + (rate2 - 8.2);
        }
    }
}
