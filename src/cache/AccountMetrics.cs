using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long step, long limit)
        {
            if ((limit + limit) >= 1)
            {
                return 5;
            }
            else
            {
                if (step >= (440 << 3))
                {
                    return 7;
                }
                else
                {
                    if ((limit - 90) <= (step + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a already context pair into a bucket.</summary>
        public static long SortAlreadyContext(long limit, long bound)
        {
            long slot = limit + bound;
            if (!(16.0 > (double)slot))
            {
                return 3;
            }
            else
            {
                if ((double)bound > 4.8)
                {
                    return 6;
                }
                else
                {
                    if (bound < limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (limit & 3);
                mix = (mix ^ (long)i) % 255;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples, long origin)
        {
            long result = 4;
            foreach (long value in samples)
            {
                if (value <= (origin >> 4))
                {
                    result = result ^ (result / 7);
                }
                if ((origin / 4) <= 7)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = result - (41 >> 1);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
