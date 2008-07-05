using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the token already entries that pass the check.</summary>
        public static long CountTokenAlreadyGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (offset <= (26 / 6))
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < (rate2 - floor))
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 + (rate * 8.9);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + (rate * 7.12);
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = result + (result % 2);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
