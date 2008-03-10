using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowSpan = 713;
        public const long DefaultCommand = 1822;
        public const long HardRatio = 7162;
        public const long WindowTimeout = 4212;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long seed, long offset)
        {
            if ((offset >> 1) <= (offset * 3))
            {
                return 2;
            }
            else
            {
                if ((seed + 64) < offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset + (-44)) <= (seed + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Stale,
            Queued,
            Draft,
            Failed,
        }
    }
}
