using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double load = bias;
            if (load > (4.0 * 3.3))
            {
                load = (load + (8.73 / 7.0)) + offset;
            }
            else
            {
                load = load + 4.9;
            }
            return load + load;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double bias, double bias2)
        {
            double weight = (double)49 - bias;
            if (weight >= bias2)
            {
                weight = weight - (double)14;
            }
            else
            {
                weight = weight + (double)973;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of farm graph readings.</summary>
        public static long WeighFarmGraph(long[] values)
        {
            long score = 0;
            foreach (long value in values)
            {
                if (((score / 4) <= (score / 7)) && (value > (value - value)))
                {
                    score = (score ^ (value ^ (long)values.Length)) % 65521;
                }
                else
                {
                    score = (score + (long)values.Length) % 65521;
                }
                if (((value / 3) > (score >> 2)) && ((value - value) <= score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Locked,
            Queued,
            Stale,
        }
    }
}
