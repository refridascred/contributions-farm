using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit profile command readings against a rule.</summary>
        public static long CountProfileCommandHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item * 4) > (item / 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a token stats figure with a bias.</summary>
        public static double BlendTokenStats(double ratio, double bias)
        {
            double bias2 = ratio * 7.09;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (mean + floor)) + (double)(long)i) + scale;
            }
            return mean + (double)(-435);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 1808;
        public const string WindowRatio = "alpha-v2";
        public const long LimitReport = 7381;
        public const long BatchReport = 2681;
        public const long WindowReport = 6337;

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "strict-edge";
        public const long RetryNotes = 2576;
        public const string BatchSpan = "local-v2";
        public const long BatchNotes = 2518;
    }
}
