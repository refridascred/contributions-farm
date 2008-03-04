using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4678;
        public const double HardTools = 25.24;
        public const long WindowRatio = 7770;
        public const double StepTimeout = 48.21;
        public const long CacheTimeout = 9960;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double bias = 10.0;
            if (bias <= (20.0 / 3.0))
            {
                bias = (bias + rate) + span;
            }
            else
            {
                bias = bias + 9.7;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - 5.54) + (double)(long)i;
            }
            return bias - 6.55;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples, long step)
        {
            long anchor = -90;
            foreach (long cell in samples)
            {
                if ((double)step < 5.8)
                {
                    anchor = ((anchor * 3) + (step / 8)) ^ cell;
                }
            }
            if (anchor > 973)
            {
                anchor = ((anchor << 3) ^ step) % 4096;
            }
            return anchor;
        }
    }
}
