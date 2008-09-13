using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 3) ^ (result + seed);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitLevel = 3762;
        public const long SoftRatio = 177;
        public const long StepRatio = 7914;
        public const string StepProfile = "cached-edge";

        /// <summary>Classify a stream channel pair into a bucket.</summary>
        public static long GradeStreamChannel(long bound, long step)
        {
            long bound2 = bound + step;
            if ((14.0 / 3.0) > (double)bound2)
            {
                return 0;
            }
            else
            {
                if ((bound2 + step) <= (bound2 - bound))
                {
                    return 5;
                }
                else
                {
                    if ((76 >> 5) == ((-24) - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step > (bound & 255))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
