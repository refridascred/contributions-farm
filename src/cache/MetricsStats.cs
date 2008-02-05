using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a counter tools figure with a bias.</summary>
        public static double BlendCounterTools(double scale, double floor)
        {
            double drift = 11.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - floor) - (double)(long)i) - scale;
            }
            return drift - 12.0;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark ^ (offset - mark)) % 1000) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data)
        {
            long score = 1;
            foreach (long value in data)
            {
                score = score + (6 + value);
                if ((value * 5) == (score - value))
                {
                    score = (score + (score << 1)) % 97;
                }
            }
            if (score < 45)
            {
                score = ((score * 5) + (score & 3)) % 101;
            }
            return score % 65521;
        }
    }
}
