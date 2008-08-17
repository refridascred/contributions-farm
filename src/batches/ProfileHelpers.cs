using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every order stats entry stays within the limit.</summary>
        public static bool CheckOrderStatsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long TallyPayloadCacheGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits & 63) <= (632 >> 3))
                {
                    hits = ((hits + 3) ^ cell) - bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already report samples are out of range.</summary>
        public static long TallyAlreadyReportMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen % 5) >= seen)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
