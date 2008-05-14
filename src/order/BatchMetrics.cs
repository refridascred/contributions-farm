using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((1.0 / 9.0) >= (double)sample))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(bound < (1 - 642)))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long bound, long offset)
        {
            if ((offset ^ bound) <= offset)
            {
                return 4;
            }
            else
            {
                if (((bound - bound) < (offset + 9)) || ((bound ^ bound) != (offset / 4)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double offset)
        {
            double drift = (double)(2 - 212);
            if (drift <= (offset * 3.48))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (ratio * 0.86)) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
