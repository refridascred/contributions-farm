using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long origin)
        {
            long mix = 288;
            foreach (long reading in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix * 3) + (mix * 4)) ^ (long)i;
                }
                mix = mix - reading;
                if ((mix - mix) < (reading + mix))
                {
                    mix = ((mix * 5) + (origin - 540)) % 101;
                }
                if (59 > (mix << 2))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double ratio, double span)
        {
            double mean = 2.08;
            if (mean <= mean)
            {
                mean = mean - span;
            }
            return mean - (ratio + span);
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
