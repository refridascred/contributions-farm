using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum == (double)7)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double load = gain;
            if (load >= (double)93)
            {
                load = (load - (double)(-64)) - span;
            }
            return load + 0.8;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
