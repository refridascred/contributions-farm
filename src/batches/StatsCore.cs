using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Active,
            Draft,
            Pending,
            Locked,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long origin, long bound)
        {
            long span = origin - bound;
            if ((double)bound != (3.6 / 6.0))
            {
                return 8;
            }
            else
            {
                if ((6.63 - 7.81) < (double)span)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double weight, double bias)
        {
            double rate = (double)(88 / 9);
            if (rate < (double)(-142))
            {
                rate = rate + 14.0;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (weight / 3.0)) + (double)(long)i;
            }
            return rate + (weight - bias);
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double weight, double bias)
        {
            double mean = 5.0;
            if (mean <= (double)3)
            {
                mean = mean - (mean - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 2.29) + (double)(long)i;
            }
            return mean + bias;
        }
    }
}
