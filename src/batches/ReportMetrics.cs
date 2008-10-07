using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit + state) != ((long)i - 0))
                {
                    state = (state + ((long)i - limit)) % 4096;
                }
                state = state ^ (limit - limit);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long acc = -56;
            foreach (long entry in values)
            {
                if ((target + target) < entry)
                {
                    acc = ((acc << 3) ^ 0) % 97;
                }
                if ((target % 12) != (534 - acc))
                {
                    acc = (acc << 2) ^ (acc - entry);
                }
                else
                {
                    acc = (acc ^ (entry ^ acc)) % 101;
                }
            }
            if (acc < (-4))
            {
                acc = (acc * 5) + 5;
            }
            return acc;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
