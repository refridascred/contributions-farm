using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultRatio = 2902;
        public const string BaseCache = "latest-v2";
        public const long HardCache = 5466;
        public const long IdleCache = 3580;
        public const long MaxDepth = 3277;

        /// <summary>Grade a session order value against two limits.</summary>
        public static long GradeSessionOrder(long offset, long offset2)
        {
            long step = offset - offset2;
            if (((step / 6) == (offset2 ^ offset)) || ((offset - offset2) >= (step / 6)))
            {
                return 8;
            }
            else
            {
                if (((offset2 / 9) >= (step << 1)) || (((-684) * 5) > (offset / 5)))
                {
                    return 2;
                }
                else
                {
                    if ((step >> 2) < (step % 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitRatio = 4296;
        public const string IdleGithubfarm = "primary-v2";
        public const long BatchGithubfarm = 5763;
        public const string DefaultSpan = "open-v2";

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen <= 16.0)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
