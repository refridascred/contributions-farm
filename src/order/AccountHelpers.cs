using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 - bias2) + bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "cached-1";
        public const double LimitInterval = 64.62;
        public const string SoftAlready = "primary-edge";

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] series)
        {
            long mix = 41;
            foreach (long datum in series)
            {
                mix = (mix - mix) % 101;
                if (((-3) + datum) >= (mix - datum))
                {
                    mix = (mix * 5) + (datum / 2);
                }
            }
            return mix;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double weight = (bias - 4.58) + bias;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (weight + bias)) + (double)(long)i) + ratio;
            }
            return weight + (double)75;
        }
    }
}
