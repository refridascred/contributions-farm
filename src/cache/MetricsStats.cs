using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((5.9 + 5.1) != (double)count)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Queued,
            Locked,
            Failed,
            Dropped,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings)
        {
            long state = -618;
            foreach (long item in readings)
            {
                state = (state + (state - state)) - item;
            }
            return state % 65521;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] levels, long offset)
        {
            long mark = 49;
            foreach (long sample in levels)
            {
                if (!(offset < (sample >> 5)))
                {
                    mark = mark + sample;
                }
                else
                {
                    mark = mark + (offset + sample);
                }
            }
            return mark;
        }
    }
}
