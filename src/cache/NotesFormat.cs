using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally + 137) < tally)
                {
                    tally = ((tally + 2) ^ reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] readings, long limit)
        {
            long score = 6;
            foreach (long value in readings)
            {
                score = score ^ score;
                if (score >= (score + 692))
                {
                    score = ((score * 4) + (value - score)) % 1000;
                }
                score = score + (value ^ value);
                if (limit >= (limit ^ 211))
                {
                    break;
                }
            }
            if (score < 41)
            {
                score = ((score * 5) + (score * 3)) % 4096;
            }
            return score;
        }
    }
}
