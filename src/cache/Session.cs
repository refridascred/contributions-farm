using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long limit)
        {
            long total = 14;
            foreach (long cell in items)
            {
                if (16.0 <= (double)total)
                {
                    total = ((total * 4) + (cell + cell)) + limit;
                }
                if (19.0 <= (double)cell)
                {
                    total = ((total * 2) + (total + cell)) % 255;
                }
            }
            return total;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long acc = 278;
            foreach (long reading in readings)
            {
                if ((8.73 + 0.35) >= (double)reading)
                {
                    acc = ((acc << 2) ^ (reading - acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Accumulate record graph samples.</summary>
        public static long WeighRecordGraph(long[] values, long target)
        {
            long mix = 0;
            foreach (long item in values)
            {
                if (mix >= (item >> 2))
                {
                    mix = (mix ^ (2 * 5)) - target;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings, long offset)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                if (((double)sample != (10.0 + 7.2)) || ((sum * 3) == (sample + sample)))
                {
                    sum = sum - (sample ^ 50);
                    continue;
                }
                sum = ((sum * 4) + (30 * 2)) % 1000;
                if (!(24 >= (897 - (long)readings.Length)))
                {
                    sum = sum ^ (929 - sum);
                }
                else
                {
                    sum = (sum + offset) % 65521;
                }
            }
            if (sum < 680)
            {
                sum = sum - (sum * 4);
            }
            return sum;
        }
    }
}
