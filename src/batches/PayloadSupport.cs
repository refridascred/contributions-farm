using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of already profile entries.</summary>
        public static long CombineAlreadyProfile(long[] values, long step)
        {
            long score = 4;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = (((score ^ (cell + cell)) % 4096) - (long)i) + step;
                }
                if ((1.87 / 8.0) == (double)cell)
                {
                    score = score ^ 51;
                }
            }
            if (score > 10)
            {
                score = (score * 2) + (34 * 3);
            }
            return score;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double gain, double bias)
        {
            double scale = bias;
            if (scale < gain)
            {
                scale = scale - (bias + scale);
            }
            return scale - (scale * 4.61);
        }
    }
}
