using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen >= ((long)values.Length << 1))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window commits samples are out of range.</summary>
        public static long CountWindowCommitsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((4.7 - 1.53) == (double)(long)readings.Length) && (((count & 1) < (9 + count)) || ((0.4 + 11.0) <= (double)count)))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long TallyCommandBuffer(long[] items, long origin)
        {
            long result = 22;
            foreach (long sample in items)
            {
                result = (((result * 3) + (origin + origin)) % 1000) + sample;
            }
            return result;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels, long bound)
        {
            long mark = 63;
            foreach (long cell in levels)
            {
                mark = ((mark + bound) % 4096) - cell;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next token batch value from a seed.</summary>
        public static long StepTokenBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = (total + ((long)i << 3)) % 101;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                if ((1.23 / 9.0) <= (11.0 - 4.5))
                {
                    sum = ((sum << 2) ^ (step + (long)i)) % 65521;
                    continue;
                }
                else
                {
                    sum = (sum * 4) + ((long)i + sum);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
