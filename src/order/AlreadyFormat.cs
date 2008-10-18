using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long seed)
        {
            long acc = 47;
            foreach (long item in samples)
            {
                acc = ((acc ^ (acc * 3)) % 255) ^ item;
            }
            if (acc < (-9))
            {
                acc = (acc - (seed + seed)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally / 8) > (sample >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double ratio = gain;
            if (ratio >= floor)
            {
                ratio = ratio + (ratio + 5.58);
            }
            else
            {
                ratio = ratio + (gain * 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)590) + (double)(long)i;
            }
            return ratio + (ratio + gain);
        }
    }
}
