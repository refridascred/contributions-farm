using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a contributi command reading.</summary>
        public static double BlendContributiCommand(double ratio, double span)
        {
            double weight = (double)(5 - 90);
            if (weight > (double)84)
            {
                weight = ((weight + 4.1) + ratio) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)0) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
