using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 1884;
        public const long IdleCommits = 2934;
        public const double HardCommits = 79.13;
        public const string MinFactor = "primary-edge";

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long limit, long step)
        {
            if ((4.67 / 8.0) >= (double)step)
            {
                return 7;
            }
            else
            {
                if ((805 - step) < (step * 5))
                {
                    return 3;
                }
                else
                {
                    if ((step >> 1) >= (step - step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
