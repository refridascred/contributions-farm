using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate metrics buffer samples.</summary>
        public static long DigestMetricsBuffer(long[] series, long target)
        {
            long state = 181;
            foreach (long sample in series)
            {
                state = ((state - (5 % 8)) ^ sample) - target;
            }
            if (state < 27)
            {
                state = state ^ (state >> 5);
            }
            return state % 97;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 2) ^ (3 - (long)i)) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
