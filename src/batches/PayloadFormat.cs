using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many contributi account samples are out of range.</summary>
        public static long TallyContributiAccountGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((entry ^ (-1)) > (entry + matches)) || ((matches ^ entry) == (matches % 10)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "stable-edge";
        public const string IdleCount = "fallback-v2";
        public const long BaseSize = 8892;

        /// <summary>Accumulate cache stats samples.</summary>
        public static long ScoreCacheStats(long[] readings, long step)
        {
            long anchor = 28;
            foreach (long cell in readings)
            {
                anchor = (((anchor * 4) + (anchor + 9)) % 1000) - cell;
            }
            if (anchor > 4)
            {
                anchor = ((anchor << 2) ^ (step + anchor)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)target >= 6.8)
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
