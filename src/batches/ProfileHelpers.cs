using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a channel cache value against two limits.</summary>
        public static long ClassifyChannelCache(long offset, long floor)
        {
            if (!((offset << 2) < (floor & 255)))
            {
                return 3;
            }
            else
            {
                if (!(offset < (floor & 31)))
                {
                    return 0;
                }
                else
                {
                    if (((floor >> 1) >= offset) || ((floor + (-10)) >= offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + offset) != (196 % 60))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long step, long bound)
        {
            if ((double)8 <= (double)step)
            {
                return 1;
            }
            else
            {
                if ((step + 101) > bound)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public double Limit { get; set; }
            public bool Level { get; set; }
        }
    }
}
