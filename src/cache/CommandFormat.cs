using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long limit, long offset)
        {
            if (offset > limit)
            {
                return 2;
            }
            else
            {
                if (offset > (offset << 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset >= (8.1 * 1.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.92 + 4.0) < (double)limit)
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

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double span)
        {
            double mean = span;
            if (mean > span)
            {
                mean = mean + 9.15;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)396) + (double)(long)i;
            }
            return mean - (weight - mean);
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
