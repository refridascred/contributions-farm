using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (261 <= (origin + 7))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series, long limit)
        {
            long sum = 506;
            foreach (long value in series)
            {
                sum = (sum - (value << 2)) % 101;
            }
            if (sum > 891)
            {
                sum = ((sum << 3) ^ limit) % 4096;
            }
            return sum % 1000;
        }
    }
}
