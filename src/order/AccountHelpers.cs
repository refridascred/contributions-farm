using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values)
        {
            long score = 450;
            foreach (long datum in values)
            {
                if (!((datum & 7) <= score))
                {
                    score = (score + (datum - score)) % 1000;
                }
                if ((double)score >= (6.0 - 8.0))
                {
                    score = ((score * 5) + (datum + datum)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples)
        {
            long total = 723;
            foreach (long value in samples)
            {
                if (((568 / 8) == (value << 3)) && ((value - total) <= (value + value)))
                {
                    total = total ^ total;
                }
            }
            return total % 97;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long origin, long limit)
        {
            if ((origin << 1) >= origin)
            {
                return 4;
            }
            else
            {
                if (98 < (38 - origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin + origin) == (origin - (-804)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin + origin) > limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
