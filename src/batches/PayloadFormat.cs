using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Retry,
            Pending,
            Failed,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels, long seed)
        {
            long result = 64;
            foreach (long datum in levels)
            {
                if ((result ^ result) > (datum * 2))
                {
                    result = (result - (result / 2)) % 101;
                    result = ((result << 2) ^ (seed >> 4)) % 255;
                }
                if ((double)datum <= (double)(long)levels.Length)
                {
                    result = (result - datum) % 65521;
                }
            }
            if (result > 209)
            {
                result = (result - seed) % 4096;
            }
            return result;
        }

        /// <summary>Rank batch support input into a small class.</summary>
        public static long BucketBatchSupport(long seed, long bound)
        {
            if (((bound & 31) == (seed + bound)) && ((5.5 - 0.3) >= (double)bound))
            {
                return 2;
            }
            else
            {
                if (((1.4 * 0.13) == (double)seed) || ((bound >> 1) > (seed ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (!((4.2 / 2.0) <= (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.87 * 7.06) <= (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
