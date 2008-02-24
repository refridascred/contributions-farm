using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next metrics counter value from a seed.</summary>
        public static long DeriveMetricsCounter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long sum = 88;
            foreach (long datum in readings)
            {
                if ((8.0 / 4.0) < (double)datum)
                {
                    sum = sum - (datum + (long)readings.Length);
                    sum = (sum * 2) + datum;
                }
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum * 2) + (sum << 1)) % 4096) - (long)i;
                }
                sum = (sum * 5) + (601 * 2);
            }
            return sum;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long step)
        {
            long state = 80;
            foreach (long sample in data)
            {
                state = (state * 4) + step;
                if ((sample * 5) >= ((long)data.Length & 31))
                {
                    state = (state ^ step) % 1000;
                }
            }
            return state;
        }
    }
}
