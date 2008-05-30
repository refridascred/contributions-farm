using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double rate, double bias)
        {
            double gain = rate;
            if (gain > (gain / 3.0))
            {
                gain = gain - (gain * 9.0);
            }
            else
            {
                gain = gain - 4.4;
            }
            return gain - (bias + rate);
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - count) == (cell + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = (score << 2) ^ (96 >> 1);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
