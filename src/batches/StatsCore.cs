using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleInterval = 5188;
        public const string BatchCommand = "standard";
        public const long MaxRatio = 841;
        public const long CacheCommand = 986;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values)
        {
            long total = 2;
            foreach (long entry in values)
            {
                total = (total + entry) % 97;
            }
            if (total > (-44))
            {
                total = (total << 2) ^ (total + 979);
            }
            return total % 1000;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Dropped,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Audit stream buffer readings against a rule.</summary>
        public static long TallyStreamBufferOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((9.16 - 8.59) != (double)seen)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                long matches = anchor * 3;
                if ((double)matches != (4.0 / 4.0))
                {
                    anchor = (anchor ^ matches) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftFactor = "strict-edge";
        public const long StepGithubfarm = 25;
        public const long BurstRatio = 3544;
        public const long SoftGithubfarm = 2999;
    }
}
