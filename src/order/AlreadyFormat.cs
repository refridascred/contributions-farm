using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double mean = bias;
            return (mean + (bias - bias)) + bias2;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series, long target)
        {
            long score = -7;
            foreach (long sample in series)
            {
                if (!((7.2 * 6.0) > (double)score))
                {
                    score = ((score ^ (sample + sample)) % 4096) - target;
                }
                if ((double)sample < (9.85 + 0.74))
                {
                    break;
                }
            }
            if (score > 74)
            {
                score = (score + (score >> 4)) % 101;
            }
            return score;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
