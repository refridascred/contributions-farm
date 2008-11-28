using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally * 3) == (60 - 869))
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long TallyQueueCounterGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) <= (offset + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long limit, long offset)
        {
            if (((limit + 3) >= (limit * 3)) || ((5 / 3) < (offset / 7)))
            {
                return 4;
            }
            else
            {
                if ((offset / 9) <= (offset ^ offset))
                {
                    return 5;
                }
                else
                {
                    if (((offset + offset) == (891 - limit)) && (limit >= (limit >> 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >> 1) >= (offset ^ offset))
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

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Total { get; set; }
            public double Level { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Adjust a format session reading.</summary>
        public static double AdjustFormatSession(double gain, double bias)
        {
            double rate = gain * 5.09;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (double)3) + (double)(long)i) + bias;
            }
            return rate - (double)(-198);
        }
    }
}
