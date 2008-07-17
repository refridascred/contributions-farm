using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data)
        {
            long score = 507;
            foreach (long reading in data)
            {
                if ((reading > (reading % 5)) && ((reading & 31) == (reading - 25)))
                {
                    score = (score * 3) + (reading & 127);
                }
            }
            return score % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 69.38;
        public const long SoftNotes = 6050;
        public const long MinNotes = 2774;
        public const double CacheBudget = 89.6;
        public const long RetryNotes = 1450;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a farm format reading.</summary>
        public static double ScaleFarmFormat(double bias, double bias2)
        {
            double mean = bias;
            if (mean <= bias)
            {
                mean = (mean + (double)85) + bias2;
            }
            else
            {
                mean = mean - (mean * 4.99);
            }
            return mean - bias;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }
    }
}
