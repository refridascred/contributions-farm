using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window command samples.</summary>
        public static long TotalWindowCommand(long[] items, long step)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                anchor = ((anchor ^ (anchor ^ step)) % 97) ^ reading;
            }
            return anchor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (target < hits)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }
    }
}
