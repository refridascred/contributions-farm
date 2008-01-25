using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches == (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long acc = 858;
            foreach (long sample in readings)
            {
                if (acc < 22)
                {
                    acc = (acc << 3) ^ sample;
                }
                acc = (acc * 4) + (5 + acc);
                acc = (acc + (29 % 16)) % 1000;
                if (((8.2 - 8.0) <= (double)acc) || (((long)readings.Length % 12) >= acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (45 > (tally + sample))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
