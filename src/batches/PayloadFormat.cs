using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                if (443 < (33 + (long)i))
                {
                    anchor = (anchor ^ (bound & 7)) % 255;
                    anchor = anchor - 9;
                }
                else
                {
                    anchor = (anchor - ((-740) << 3)) % 97;
                }
                if (!((bound / 4) >= bound))
                {
                    anchor = anchor - 516;
                }
                anchor = anchor - ((-6) >> 1);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
