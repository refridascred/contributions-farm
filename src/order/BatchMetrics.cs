using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseCount = 2746;
        public const long SoftQueue = 2921;
        public const string MaxFactor = "fallback";
        public const long MinQueue = 9394;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Combine token entry values into a single score.</summary>
        public static long DigestTokenEntry(long[] samples)
        {
            long acc = 99;
            foreach (long sample in samples)
            {
                acc = (acc * 4) + 3;
                if (((double)sample <= 7.27) && ((61 + sample) != (8 + sample)))
                {
                    acc = (acc << 2) ^ ((long)samples.Length + sample);
                }
            }
            if (acc < 39)
            {
                acc = ((acc << 2) ^ ((long)samples.Length + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long limit)
        {
            if ((limit - 929) != (730 + bound))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) != (4 + bound))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
