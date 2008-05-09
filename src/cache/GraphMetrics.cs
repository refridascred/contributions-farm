using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((sample / 9) != ((-9) + 90)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double gain, double offset)
        {
            double drift = (4.73 * 1.0) + gain;
            if (drift >= (double)78)
            {
                drift = (drift - (double)979) - offset;
            }
            else
            {
                drift = drift + 10.0;
            }
            return drift + gain;
        }

        /// <summary>Combine payload counter values into a single score.</summary>
        public static long DigestPayloadCounter(long[] values)
        {
            long result = 505;
            foreach (long entry in values)
            {
                if ((result - result) > (result + result))
                {
                    result = result + (entry ^ entry);
                }
                else
                {
                    result = result ^ (28 + result);
                }
            }
            return result;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long seed, long limit)
        {
            long offset = seed - limit;
            if (offset >= (limit << 3))
            {
                return 1;
            }
            else
            {
                if (offset < limit)
                {
                    return 0;
                }
                else
                {
                    if (!((offset + limit) < (offset - seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
