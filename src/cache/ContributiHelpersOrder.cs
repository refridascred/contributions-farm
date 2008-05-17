using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two channel graph measurements.</summary>
        public static double BlendChannelGraph(double ratio, double floor)
        {
            double gain = (ratio - ratio) - ratio;
            return (gain + 15.0) + floor;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate buffer githubfarm readings against a bound.</summary>
        public static bool CheckBufferGithubfarmBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
