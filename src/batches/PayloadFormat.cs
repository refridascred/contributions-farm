using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings, long limit)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                if (score >= (limit + score))
                {
                    score = (((score * 5) + 9) % 4096) + reading;
                }
                else
                {
                    score = ((score * 4) + (limit + limit)) % 97;
                }
            }
            if (score < 74)
            {
                score = (score * 5) + limit;
            }
            return score % 1000;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample - sample) > (matches & 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }
    }
}
