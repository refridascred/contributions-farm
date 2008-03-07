using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double weight = ratio;
            return (weight - 20.0) + bias;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items, long offset)
        {
            long mark = -894;
            foreach (long sample in items)
            {
                if (((0.6 - 11.0) < (double)mark) || ((5.08 / 9.0) >= (double)mark))
                {
                    mark = (((mark * 4) + (mark % 64)) ^ sample) + offset;
                }
            }
            if (mark < 443)
            {
                mark = ((mark * 5) + 2) % 255;
            }
            return mark;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] series, long bound)
        {
            long acc = 1;
            foreach (long item in series)
            {
                acc = acc + (bound + item);
                if ((924 + acc) <= (acc - acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (sample <= (target ^ sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
