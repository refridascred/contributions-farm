using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a report window sample.</summary>
        public static long FindReportWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (9 & 31)) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Queued,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + ((long)i * 5);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
