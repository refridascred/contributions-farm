using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long bound, long origin)
        {
            if ((bound - bound) < origin)
            {
                return 4;
            }
            else
            {
                if ((origin * 2) > (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 3) ^ (-5)) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long seed)
        {
            long span = offset ^ seed;
            if (((offset - offset) <= (seed ^ span)) && ((double)offset != (double)55))
            {
                return 0;
            }
            else
            {
                if ((seed < (span - seed)) && ((double)offset == (6.8 / 4.0)))
                {
                    return 3;
                }
                else
                {
                    if ((80 / 5) < offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed >= (span - seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((origin - carry) > (1 + (-652)))
                {
                    continue;
                }
                else
                {
                    carry = carry + (origin << 3);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
