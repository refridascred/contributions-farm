using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = (score + (long)i) % 255;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (double)(long)i) + bias;
            }
            return weight - floor;
        }
    }
}
