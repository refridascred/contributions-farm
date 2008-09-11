using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                if ((result + target) >= (long)i)
                {
                    result = result ^ (4 >> 5);
                    result = (result ^ (long)i) % 65521;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double floor)
        {
            double gain = (double)(498 - 399);
            if (gain > rate)
            {
                gain = (gain - rate) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (rate * 9.8)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Stale,
            Closed,
            Pending,
        }
    }
}
