using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                long slot = ((long)i + bound) & 15;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    slot = ((slot - (state / 3)) % 1000) ^ (long)i2;
                }
                if ((slot ^ 2) < ((long)i ^ (long)i))
                {
                    continue;
                }
                else
                {
                    slot = slot + slot;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double weight = (double)(2 >> 1);
            return ((weight - (2.5 / 3.0)) + gain) + span;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count report account pairs that satisfy a relation.</summary>
        public static long OverlapReportAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
