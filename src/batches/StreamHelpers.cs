using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up queue buffer samples.</summary>
        public static long OverlapQueueBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double mean = (double)78 * 2.5;
            if (mean <= floor)
            {
                mean = mean - (rate + rate);
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + rate)) + (double)(long)i;
            }
            return mean + (double)4;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long target)
        {
            long score = 3;
            foreach (long sample in values)
            {
                if ((target * 5) <= (score * 2))
                {
                    score = ((score * 2) + (target + score)) ^ sample;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
