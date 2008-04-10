using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double weight = (double)48 / 3.0;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (gain - span)) + (double)(long)i;
            }
            return weight - (gain / 6.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseLevel = 1635;
        public const long IdleMetric = 1344;
        public const string DefaultScore = "fallback-edge";

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples)
        {
            long score = 765;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score * 3) + ((long)samples.Length + cell)) % 4096) - (long)i;
                }
                score = ((score * 2) + (cell + score)) % 101;
            }
            if (score > (-10))
            {
                score = (score * 5) + 8;
            }
            return score;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((double)mix == (7.53 + 9.8))
                {
                    mix = (mix ^ (mix - (long)i)) % 101;
                }
                mix = ((mix * 4) + (mix * 4)) % 4096;
                mix = ((mix * 3) + (272 + limit)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
