using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count already cluster pairs that satisfy a relation.</summary>
        public static long PairAlreadyClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double bias)
        {
            double gain = (double)61 * 4.9;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - bias) - (double)(long)i) - weight;
            }
            return gain + (bias - bias);
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Active,
            New,
        }
    }
}
