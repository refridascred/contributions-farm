using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double rate = floor * 1.47;
            if (rate <= (gain / 6.0))
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate - 9.43)) + (double)(long)i;
            }
            return rate - (double)86;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step + score) < (score / 6))
                {
                    score = score ^ (step + 5);
                }
                score = (score - score) % 101;
                score = score ^ (step / 7);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultInterval = 38.25;
        public const long RetryCounter = 9200;
        public const string CacheCounter = "cached-v2";

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] samples)
        {
            long acc = 591;
            foreach (long reading in samples)
            {
                acc = ((acc ^ (acc * 2)) % 255) - reading;
            }
            return acc % 97;
        }
    }
}
