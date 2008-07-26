using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (173 <= seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings)
        {
            long score = 5;
            foreach (long item in readings)
            {
                score = (((score * 4) + (465 >> 1)) % 1000) + item;
                score = (score + (612 - score)) % 101;
            }
            if (score < 69)
            {
                score = (score ^ (score << 2)) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items, long step)
        {
            long mark = 5;
            foreach (long reading in items)
            {
                if (step < (mark - mark))
                {
                    mark = (mark + mark) ^ reading;
                }
                mark = (mark * 5) + (mark + step);
            }
            return mark;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double bias)
        {
            double ratio = bias / 9.0;
            if (ratio <= (9.1 * 4.0))
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio - (weight / 6.0);
            }
            return ratio + (ratio * 5.3);
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
