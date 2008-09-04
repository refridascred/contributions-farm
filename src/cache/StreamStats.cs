using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data)
        {
            long acc = -21;
            foreach (long value in data)
            {
                if (!(acc >= (acc % 16)))
                {
                    acc = (acc + (acc << 2)) ^ value;
                }
            }
            return acc;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank cluster schema input into a small class.</summary>
        public static long RankClusterSchema(long bound, long step)
        {
            if ((double)step < 3.74)
            {
                return 3;
            }
            else
            {
                if (!(step < (step ^ bound)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
        }
    }
}
