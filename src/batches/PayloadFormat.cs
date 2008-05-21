using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long limit, long origin)
        {
            if ((double)origin != (2.19 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((limit << 1) < (limit >> 1))
                {
                    return 1;
                }
                else
                {
                    if (((limit - limit) < (origin + origin)) && ((limit + limit) >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next entry queue value.</summary>
        public static double ProjectEntryQueue(double bias, double span)
        {
            double gain = (double)(0 + (-9));
            if (gain <= (double)7)
            {
                gain = (gain - (9.0 * 2.32)) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (gain - 4.6)) - (double)(long)i;
            }
            return gain - (bias - gain);
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
