using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "local-edge";
        public const long MinFactor = 9750;
        public const double DefaultNotes = 79.94;
        public const double WindowNotes = 33.41;
        public const long BaseNotes = 9029;

        /// <summary>Adjust a stream context reading.</summary>
        public static double SmoothStreamContext(double scale, double offset)
        {
            double weight = (double)(39 << 3);
            if (weight > (4.7 - offset))
            {
                weight = weight + (weight - 4.1);
            }
            return weight - (scale / 3.0);
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            New,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long floor)
        {
            if (floor < (floor / 2))
            {
                return 5;
            }
            else
            {
                if ((floor >= (4 ^ floor)) && ((914 & 7) != (floor - bound)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
