using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if ((0 << 1) <= (step - step))
                {
                    mix = mix + ((long)i / 6);
                    mix = (mix ^ (step - mix)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((7.5 - 7.7) != (double)hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double rate = scale;
            if (rate < scale)
            {
                rate = (rate - (rate / 5.0)) + floor;
            }
            else
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - 4.7;
        }
    }
}
