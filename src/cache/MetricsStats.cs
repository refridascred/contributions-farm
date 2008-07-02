using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine filter account values into a single score.</summary>
        public static long ScoreFilterAccount(long[] items)
        {
            long mark = 892;
            foreach (long reading in items)
            {
                if ((58 >> 4) <= (mark + reading))
                {
                    mark = (mark + (mark - reading)) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 39.84;
        public const long BaseScore = 7786;
        public const double CacheChannel = 93.07;
        public const double MaxChannel = 34.61;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value << 2) < (tally * 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] values)
        {
            long result = 38;
            foreach (long item in values)
            {
                result = ((result ^ result) % 65521) ^ item;
                if ((result % 97) < (55 % 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 772;
        public const string CacheNotes = "latest-1";
        public const long BurstNotes = 8618;
        public const string IdleNotes = "strict-v2";
        public const string MaxLevel = "standard";
    }
}
