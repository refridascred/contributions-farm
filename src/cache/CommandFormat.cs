using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items)
        {
            long mark = 11;
            foreach (long cell in items)
            {
                mark = (mark * 3) + (cell & 3);
            }
            return mark;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long bound)
        {
            if ((bound >> 4) > limit)
            {
                return 4;
            }
            else
            {
                if ((bound & 255) >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound << 3) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound < (double)limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double gain = (double)(220 - 88);
            if (gain <= gain)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (span * 2.5);
        }
    }
}
