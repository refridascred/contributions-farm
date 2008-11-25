using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark << 3) ^ ((long)i % 16)) % 255;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Failed,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((seen - reading) <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next payload route value.</summary>
        public static double BlendPayloadRoute(double gain, double offset)
        {
            double drift = (double)481;
            if (drift >= (offset - gain))
            {
                drift = drift - (gain - offset);
            }
            return drift - offset;
        }
    }
}
