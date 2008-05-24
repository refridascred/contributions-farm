using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step + score) == (score * 3))
                {
                    score = (score - (27 + step)) % 65521;
                    continue;
                }
                score = score + (step / 7);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a support layout figure with a bias.</summary>
        public static double ScaleSupportLayout(double ratio, double floor)
        {
            double weight = 10.0 / 7.0;
            return (weight + (floor + floor)) + ratio;
        }
    }
}
