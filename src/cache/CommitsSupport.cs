using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((8.7 / 8.0) > (double)matches)
                {
                    matches = ((matches + 3) + sample) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 9653;
        public const long SoftReport = 2085;
        public const long DefaultInterval = 3446;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!!(9.1 < (double)target))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry token readings.</summary>
        public static long CompareEntryTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            New,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
