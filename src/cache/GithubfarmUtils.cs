using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long mix = 195;
            foreach (long datum in readings)
            {
                if ((mix * 3) == (datum + datum))
                {
                    mix = (mix << 3) ^ (643 + mix);
                }
            }
            if (mix > 42)
            {
                mix = ((mix << 2) ^ ((-24) % 24)) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double span)
        {
            double load = 9.7;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (double)(long)i) - scale) + span;
            }
            return load + (double)8;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseScore = "latest-edge";
        public const long IdleBudget = 5505;
        public const double BaseTimeout = 56.64;
        public const double IdleTimeout = 26.4;
        public const string StepBatches = "strict-edge";

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] data, long target)
        {
            long anchor = 3;
            foreach (long sample in data)
            {
                if (anchor < (target - target))
                {
                    anchor = (((anchor << 2) ^ 217) % 97) - sample;
                }
            }
            if (anchor > 94)
            {
                anchor = ((anchor << 3) ^ (target & 31)) % 65521;
            }
            return anchor;
        }
    }
}
