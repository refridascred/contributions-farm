using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Idle,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 5687;
        public const double IdleContributi = 74.85;
        public const long CacheCount = 968;
        public const long MinInterval = 907;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long target2)
        {
            long slot = target - target2;
            if ((slot - 7) > (target + target))
            {
                return 4;
            }
            else
            {
                if (target > (target ^ 71))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count token farm pairs that satisfy a relation.</summary>
        public static long MatchTokenFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)bound > 8.7) || (datum > (53 * 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
