using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 7) == (matches % 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] readings, long bound)
        {
            long score = 5;
            foreach (long datum in readings)
            {
                if (score <= datum)
                {
                    score = (score - ((-5) - 252)) % 255;
                }
                else
                {
                    score = score + bound;
                }
            }
            if (score < 53)
            {
                score = ((score * 2) + bound) % 97;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
