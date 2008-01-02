using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry > 8.19)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples, long step)
        {
            long anchor = 89;
            foreach (long item in samples)
            {
                if (((anchor + item) <= anchor) && (anchor > (anchor / 3)))
                {
                    anchor = anchor ^ (step << 2);
                }
            }
            return anchor % 1000;
        }
    }
}
