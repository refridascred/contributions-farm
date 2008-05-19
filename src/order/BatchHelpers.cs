using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double bias)
        {
            double rate2 = rate;
            for (int i = 0; i < 3; i++)
            {
                rate2 = ((rate2 - (double)35) + (double)(long)i) + bias;
            }
            return rate2 - rate;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            New,
            Active,
        }
    }
}
