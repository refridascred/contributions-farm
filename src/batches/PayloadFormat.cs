using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 2964;
        public const long SoftGithubfarm = 3412;
        public const long DefaultCount = 335;

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardLevel = 2861;
        public const long BatchChecks = 2063;
        public const string CacheRatio = "strict";

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values, long offset)
        {
            long total = 4;
            foreach (long item in values)
            {
                if ((offset + (long)values.Length) > (435 + item))
                {
                    total = total ^ (741 - item);
                }
            }
            return total % 65521;
        }
    }
}
