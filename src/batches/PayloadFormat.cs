using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long origin)
        {
            long sum = 63;
            foreach (long entry in items)
            {
                if (((sum * 5) == (sum * 2)) && ((sum << 1) <= (entry + origin)))
                {
                    sum = ((sum * 5) + (origin & 31)) % 65521;
                }
            }
            if (sum > 67)
            {
                sum = (sum ^ (sum + 21)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 4118;
        public const double BaseFactor = 29.95;
        public const long StepCount = 8568;
        public const long LimitWidth = 6167;

        /// <summary>Match up command notes samples.</summary>
        public static long MatchCommandNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
