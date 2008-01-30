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

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items)
        {
            long score = 464;
            foreach (long item in items)
            {
                score = ((score * 5) + (item >> 5)) % 1000;
            }
            if (score < (-8))
            {
                score = (score ^ (score - 14)) % 4096;
            }
            return score % 65521;
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
