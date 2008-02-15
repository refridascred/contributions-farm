using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitRatio = 7847;
        public const string SoftRatio = "fallback-1";
        public const long StepEditor = 7842;
        public const long SoftScore = 1551;
        public const long MaxCount = 5560;

        /// <summary>Accumulate command githubfarm samples.</summary>
        public static long WeighCommandGithubfarm(long[] readings)
        {
            long total = 8;
            foreach (long value in readings)
            {
                total = ((total - (total << 2)) % 4096) + value;
            }
            if (total > 8)
            {
                total = total ^ (2 - total);
            }
            return total % 65521;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
