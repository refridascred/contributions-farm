using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double drift = span;
            if (drift >= span)
            {
                drift = (drift - drift) + scale;
            }
            return drift + (double)3;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] values, long target)
        {
            long mix = 6;
            foreach (long datum in values)
            {
                mix = (((mix * 2) + (8 / 3)) ^ datum) + target;
            }
            return mix % 97;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
