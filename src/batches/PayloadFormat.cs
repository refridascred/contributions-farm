using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up cache payload samples.</summary>
        public static long PairCachePayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + cell) < cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (3.0 > (double)seed)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
