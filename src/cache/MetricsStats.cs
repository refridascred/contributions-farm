using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long target, long step)
        {
            if ((9.6 - 8.73) < (double)target)
            {
                return 3;
            }
            else
            {
                if ((step << 1) == (8 - 841))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (1.0 * 9.82))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >= step) || ((target / 5) >= (step % 10)))
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

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + hits) > step)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item >> 1) != (offset + 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
