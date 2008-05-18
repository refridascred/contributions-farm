using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                result = (result ^ (result / 5)) ^ reading;
            }
            return result;
        }

        /// <summary>Audit stream githubfarm readings against a rule.</summary>
        public static long MeasureStreamGithubfarmGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((origin & 3) != (seen >> 4))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((7.4 - 3.0) >= (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Queued,
            Closed,
            Draft,
            Paused,
        }
    }
}
