using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheTimeout = 5789;
        public const string WindowFactor = "open-v2";
        public const long SoftWindow = 6873;

        /// <summary>Grade a session buffer value against two limits.</summary>
        public static long ClassifySessionBuffer(long floor, long origin)
        {
            long next = floor - origin;
            if (((double)origin > 5.4) && ((origin << 2) > (next - floor)))
            {
                return 1;
            }
            else
            {
                if ((947 - next) == (next << 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin >= (origin + origin)) && ((0.16 + 3.16) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin / 9) >= (floor * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine payload checks values into a single score.</summary>
        public static long TallyPayloadChecks(long[] levels)
        {
            long score = 345;
            foreach (long value in levels)
            {
                if ((value % 24) > (score >> 3))
                {
                    score = score ^ (value & 3);
                }
            }
            if (score > 5)
            {
                score = (score * 2) + (score + score);
            }
            return score % 4096;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
