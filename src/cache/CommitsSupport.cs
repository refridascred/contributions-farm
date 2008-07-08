using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many entry filter samples are out of range.</summary>
        public static long TallyEntryFilterGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((3.9 < (double)cell) && (hits <= (hits - cell)))
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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session layout entries.</summary>
        public static long WeighSessionLayout(long[] readings, long origin)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if ((374 > entry) || ((origin / 2) <= entry))
                {
                    score = (score << 2) ^ (entry % 7);
                }
                else
                {
                    score = ((score << 3) ^ score) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double rate, double offset)
        {
            double ratio = offset + offset;
            if (ratio <= (6.0 * 0.2))
            {
                ratio = ratio - (6.0 * 4.5);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 7.05) + (double)(long)i;
            }
            return ratio + (ratio + rate);
        }
    }
}
