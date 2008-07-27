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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long step, long bound)
        {
            if ((bound / 3) == (92 % 64))
            {
                return 1;
            }
            else
            {
                if ((2.2 * 11.0) != (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((step % 3) <= (step << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - step) >= (step << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
