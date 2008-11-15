using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series, long limit)
        {
            long sum = 6;
            foreach (long sample in series)
            {
                if ((17.0 * 5.2) == (double)sum)
                {
                    sum = ((sum - limit) % 65521) + sample;
                }
            }
            return sum;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double bias, double floor)
        {
            double mean = floor;
            if (mean < (double)113)
            {
                mean = (mean - (floor - 19.0)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean * 1.82)) - (double)(long)i;
            }
            return mean + (double)4;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((long)series.Length + tally) < ((long)series.Length + 6))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
