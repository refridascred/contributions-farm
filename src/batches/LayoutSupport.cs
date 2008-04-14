using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double bias = span;
            if (bias >= (bias + 3.94))
            {
                bias = bias - (weight + span);
            }
            else
            {
                bias = bias - (span * 3.76);
            }
            return bias + 1.9;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultLevel = 6644;
        public const long LimitBuffer = 9922;
        public const string HardRatio = "open-v2";
        public const long MinBuffer = 7826;
    }
}
