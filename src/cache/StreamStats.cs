using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next command filter value from a seed.</summary>
        public static long SeriesCommandFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                long bound = mark * 5;
                if ((origin >> 3) >= bound)
                {
                    bound = bound - 599;
                }
                else
                {
                    mark = (mark << 3) ^ ((long)i * 2);
                }
                bound = (bound << 3) ^ (mark + bound);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long step, long step2)
        {
            long gap = step ^ step2;
            if ((gap ^ 35) >= (gap + gap))
            {
                return 3;
            }
            else
            {
                if (((gap * 4) >= gap) || ((double)gap == (6.06 * 5.3)))
                {
                    return 1;
                }
                else
                {
                    if (step < (step - step))
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
}
