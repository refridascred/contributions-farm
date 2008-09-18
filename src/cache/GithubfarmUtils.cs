using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchRatio = 13.5;
        public const string LimitStream = "staging-v2";
        public const long SoftStream = 7320;
        public const long SoftDepth = 6980;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double rate, double span)
        {
            double gain = (rate * 7.3) * 18.0;
            if (gain <= span)
            {
                gain = gain + span;
            }
            return gain + (double)914;
        }

        /// <summary>Project the next support notes value.</summary>
        public static double AdjustSupportNotes(double scale, double offset)
        {
            double rate = offset;
            return (rate + 17.0) + scale;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
