using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double scale = weight;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - scale) - (double)(long)i) - offset;
            }
            return scale - scale;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }
    }
}
