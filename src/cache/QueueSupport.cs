using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a already schema sample.</summary>
        public static long SeekAlreadySchemaIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double weight, double bias)
        {
            double load = (double)63;
            if (load <= load)
            {
                load = (load + (5.22 + weight)) - bias;
            }
            else
            {
                load = load - (double)919;
            }
            return load + weight;
        }
    }
}
