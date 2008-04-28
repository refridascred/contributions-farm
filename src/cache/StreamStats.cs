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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long seed)
        {
            if (((double)seed != (9.08 * 6.2)) && ((seed + step) < seed))
            {
                return 4;
            }
            else
            {
                if ((step * 3) <= 8)
                {
                    return 6;
                }
                else
                {
                    if (step < (seed >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
