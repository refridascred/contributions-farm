using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double scale = ratio;
            if (scale < (ratio + ratio))
            {
                scale = scale - (double)69;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale + (ratio / 6.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxFactor = "strict-1";
        public const long StepBudget = 2933;
        public const long WindowCount = 8066;
        public const double HardGraph = 42.15;
        public const double MaxScore = 54.78;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long target)
        {
            long delta = limit ^ target;
            if ((89 ^ target) != (0 + delta))
            {
                return 3;
            }
            else
            {
                if (delta <= target)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
        }
    }
}
