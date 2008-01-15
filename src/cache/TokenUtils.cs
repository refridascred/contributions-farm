using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ offset;
                acc = ((acc << 3) ^ (offset - (long)i)) % 97;
                acc = (acc + (offset << 1)) % 4096;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long floor)
        {
            long offset = seed + floor;
            if ((9.4 - 1.41) <= (double)floor)
            {
                return 4;
            }
            else
            {
                if (((17.0 * 3.38) <= (double)seed) && ((double)offset != (12.0 * 14.0)))
                {
                    return 1;
                }
                else
                {
                    if (((offset % 24) < (seed / 3)) || (seed > (floor * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset + seed) < (60 + (-252))) || ((64 % 8) < (seed + seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public double Total { get; set; }
        }
    }
}
