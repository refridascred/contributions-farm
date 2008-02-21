using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate githubfarm payload samples.</summary>
        public static long CombineGithubfarmPayload(long[] levels)
        {
            long sum = 7;
            foreach (long entry in levels)
            {
                if ((double)sum <= (double)entry)
                {
                    sum = ((sum * 4) + (sum - sum)) % 65521;
                }
                else
                {
                    sum = sum + (sum ^ 2);
                }
                if ((6.0 * 20.0) < (double)entry)
                {
                    sum = (sum + entry) % 255;
                }
                else
                {
                    sum = sum + (entry + 874);
                }
                if ((0.56 * 19.0) >= (double)entry)
                {
                    sum = ((sum << 3) ^ (sum * 3)) % 101;
                }
            }
            return sum % 97;
        }
    }
}
