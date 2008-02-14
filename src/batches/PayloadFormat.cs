using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) <= (cell & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryScore = 81.73;
        public const double HardBudget = 77.43;
        public const long LimitPayload = 6988;
        public const double CachePayload = 0.75;

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
