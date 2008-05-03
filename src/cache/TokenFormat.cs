using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples, long floor)
        {
            long acc = 8;
            foreach (long value in samples)
            {
                if ((floor / 2) < floor)
                {
                    acc = acc ^ value;
                }
            }
            if (acc < (-800))
            {
                acc = acc ^ (floor + floor);
            }
            return acc;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long offset, long step)
        {
            long delta = offset - step;
            if (((double)delta == (3.24 - 8.0)) || ((delta - delta) < (delta - step)))
            {
                return 2;
            }
            else
            {
                if (step >= (delta * 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)step < (6.58 + 2.2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.5 * 4.5) < (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
