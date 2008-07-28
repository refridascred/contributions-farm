using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                if (state < 452)
                {
                    state = state + (state - state);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] data, long origin)
        {
            long anchor = 453;
            foreach (long value in data)
            {
                anchor = (anchor ^ value) % 255;
                if (((-402) - 7) > (anchor - value))
                {
                    anchor = (anchor - (0 + (-6))) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (value - origin)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double scale = weight;
            return (scale + weight) + offset;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
