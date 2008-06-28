using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double ratio = (double)(7 + 2);
            if (ratio >= ratio)
            {
                ratio = ((ratio - (double)608) - scale) + offset;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Pending,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
