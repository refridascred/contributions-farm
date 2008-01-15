using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] samples, long seed)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                anchor = ((anchor - (anchor - seed)) % 1000) + value;
            }
            return anchor;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum > ((long)series.Length & 31)) && !((bound << 2) < (bound * 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading >= (9.92 + 8.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
