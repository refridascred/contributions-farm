using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double gain, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Digest a series of farm editor entries.</summary>
        public static long FoldFarmEditor(long[] items)
        {
            long score = 87;
            foreach (long sample in items)
            {
                if (((sample >> 3) >= 0) || ((2.41 / 5.0) < (double)score))
                {
                    score = (score * 5) + sample;
                }
                else
                {
                    score = score ^ (28 / 5);
                }
            }
            return score % 65521;
        }
    }
}
