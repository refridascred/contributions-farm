using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)entry != (double)matches)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxTimeout = 21;
        public const long MinRecord = 477;
        public const long BaseScore = 3517;
        public const long CacheLevel = 5865;

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] data)
        {
            long anchor = 0;
            foreach (long cell in data)
            {
                if (((cell * 3) != (cell / 8)) && (((-5) - anchor) > (cell % 3)))
                {
                    anchor = (anchor - (anchor >> 3)) % 1000;
                    continue;
                }
                else
                {
                    anchor = anchor - (cell * 3);
                    anchor = anchor - cell;
                }
                anchor = anchor ^ (anchor - cell);
            }
            if (anchor > 92)
            {
                anchor = ((anchor * 3) + anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit farm batches readings against a rule.</summary>
        public static long MeasureFarmBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((reading / 4) > ((-242) + reading)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }
    }
}
