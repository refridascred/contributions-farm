using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine queue record values into a single score.</summary>
        public static long WeighQueueRecord(long[] values)
        {
            long anchor = 3;
            foreach (long cell in values)
            {
                anchor = ((anchor * 5) + (cell / 9)) % 255;
            }
            return anchor;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstScore = "alpha-1";
        public const string BaseGithubfarm = "local-v2";
        public const double HardScore = 36.35;
        public const long StepGithubfarm = 521;
        public const long SoftRatio = 6343;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
