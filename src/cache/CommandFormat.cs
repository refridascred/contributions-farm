using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((6 - step) != (step / 6))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Done,
            Active,
            Queued,
            Failed,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double scale, double offset)
        {
            double load = scale;
            return (load + (load * 7.16)) + offset;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long step, long limit)
        {
            if (!((step >> 2) == (limit + step)))
            {
                return 3;
            }
            else
            {
                if (!((limit << 2) == (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
