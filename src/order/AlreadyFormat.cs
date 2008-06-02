using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long total = -205;
            foreach (long sample in levels)
            {
                if ((sample / 3) == (592 ^ sample))
                {
                    total = (total << 3) ^ 6;
                }
                else
                {
                    total = (total ^ (23 & 255)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cache command readings against a rule.</summary>
        public static long MeasureCacheCommandHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count & 31) <= (datum - bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Done,
            Paused,
        }
    }
}
