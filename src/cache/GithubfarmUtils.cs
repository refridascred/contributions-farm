using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a editor cache value against two limits.</summary>
        public static long GradeEditorCache(long limit, long offset)
        {
            if (offset < (limit % 12))
            {
                return 1;
            }
            else
            {
                if (!((limit / 3) >= (offset << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ 55) >= (offset + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-8) & 31) > (offset & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinTimeout = 7070;
        public const double SoftCache = 81.15;
        public const double HardFactor = 82.12;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
