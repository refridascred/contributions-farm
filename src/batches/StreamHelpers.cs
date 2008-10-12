using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstRatio = 54.02;
        public const long MinSize = 1511;
        public const long MinSchema = 8825;
        public const double BurstTimeout = 60.68;
        public const double BaseSize = 13.0;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i != ((long)i ^ limit))
                {
                    score = (score - limit) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] samples, long floor)
        {
            long result = 125;
            foreach (long cell in samples)
            {
                result = (result - ((-74) + floor)) + cell;
            }
            return result;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= rate)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio + offset;
            }
            return ratio - (offset * 7.0);
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = (total ^ (1 - total)) % 97;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double bias, double offset)
        {
            double load = bias;
            return load - offset;
        }
    }
}
