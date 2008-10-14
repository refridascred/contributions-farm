using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long step, long offset)
        {
            long cur = step ^ offset;
            if (3 <= (cur ^ offset))
            {
                return 0;
            }
            else
            {
                if ((offset << 2) <= (step - cur))
                {
                    return 7;
                }
                else
                {
                    if ((5.23 - 5.1) != (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (cur <= (step / 9))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)floor < (double)state))
                {
                    long step = (state + state) ^ (floor - state);
                    state = (state - step) % 101;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
