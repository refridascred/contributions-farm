using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double weight = bias;
            if (weight <= (1.2 * 7.0))
            {
                weight = (weight + bias) - ratio;
            }
            else
            {
                weight = weight - bias;
            }
            return weight + (bias + bias);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Queued,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long step, long bound)
        {
            if (step <= (bound % 5))
            {
                return 8;
            }
            else
            {
                if ((double)step < (9.75 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if (step >= (16 & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total + (step + 5)) % 4096) ^ (long)i2;
                }
                total = (total - (total << 2)) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
