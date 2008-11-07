using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double scale, double floor)
        {
            double weight = (double)(711 + 4);
            if (weight <= (double)0)
            {
                weight = (weight - (double)86) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight + (scale / 5.0);
        }

        /// <summary>Match up channel commits samples.</summary>
        public static long MatchChannelCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many order editor samples are out of range.</summary>
        public static long TallyOrderEditorMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count - origin) <= count)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
