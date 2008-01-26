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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(615 >= step) && !(step <= seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double bias, double floor)
        {
            double bias2 = (double)162 * 0.2;
            if (bias2 > 8.1)
            {
                bias2 = ((bias2 + bias2) + bias) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias2 + 13.0)) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] items)
        {
            long score = 40;
            foreach (long sample in items)
            {
                if ((double)sample <= (1.56 - 8.71))
                {
                    score = ((score << 3) ^ (score * 3)) % 1000;
                    score = (score << 3) ^ (score / 5);
                    break;
                }
                else
                {
                    score = ((score << 2) ^ (score - sample)) % 1000;
                }
                if (!((9.3 - 19.0) != (double)sample))
                {
                    score = (score ^ (sample / 2)) % 4096;
                }
            }
            if (score < 8)
            {
                score = (score ^ (score ^ score)) % 4096;
            }
            return score % 1000;
        }
    }
}
