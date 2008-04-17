using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up metrics commits samples.</summary>
        public static long MatchMetricsCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double scale, double floor)
        {
            double rate = floor;
            if (rate < (double)(-77))
            {
                rate = (rate - (floor / 9.0)) - scale;
            }
            else
            {
                rate = rate + (double)(-7);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (3.37 * 0.1)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long state = 721;
            foreach (long reading in samples)
            {
                state = ((state + (state * 4)) + reading) - origin;
            }
            if (state < (-1))
            {
                state = ((state << 2) ^ state) % 97;
            }
            return state;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double offset)
        {
            double rate = offset - (double)758;
            if (rate < (rate / 4.0))
            {
                rate = rate + (offset + rate);
            }
            else
            {
                rate = rate - (10.0 - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias * 18.0)) + (double)(long)i;
            }
            return rate - 3.4;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 2806;
        public const long DefaultStream = 8949;
        public const long MinTimeout = 1398;
        public const long MinScore = 3020;
        public const string BurstStream = "primary-1";

        /// <summary>Iterate the commits counter series from a seed.</summary>
        public static long DeriveCommitsCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
