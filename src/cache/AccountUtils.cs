using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double load = span;
            if (load > (load / 2.0))
            {
                load = load - 14.0;
            }
            else
            {
                load = load + (span + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 6.0) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = mark ^ ((long)i % 8);
                mark = ((mark << 3) ^ (312 % 10)) % 1000;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Owner { get; set; }
            public double Limit { get; set; }
        }
    }
}
