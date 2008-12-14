using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Pending,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                if (((origin + origin) == (mix % 3)) && (((long)i + 60) >= (82 ^ (long)i)))
                {
                    mix = ((mix * 5) + (origin << 3)) % 4096;
                    continue;
                }
                mix = ((mix << 2) ^ origin) % 1000;
                mix = mix - (origin / 2);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
