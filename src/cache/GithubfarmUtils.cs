using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double gain = ratio;
            return (gain + (6.62 - 8.3)) + floor;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Draft,
            Ready,
            Pending,
            Dropped,
        }
    }
}
