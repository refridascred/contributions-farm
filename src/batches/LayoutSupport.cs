using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinGithubfarm = "standard-1";
        public const string LimitGithubfarm = "open";
        public const long IdleDepth = 5846;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double weight, double span)
        {
            double scale = (weight + 6.0) / 2.0;
            if (scale <= (double)670)
            {
                scale = scale + 3.4;
            }
            else
            {
                scale = scale - span;
            }
            return scale - scale;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
