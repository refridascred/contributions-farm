using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((7.0 - 7.7) <= (double)mix)
                {
                    mix = (mix - (mix + mix)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values)
        {
            long total = 29;
            foreach (long sample in values)
            {
                if ((sample * 3) != (total + total))
                {
                    total = ((total * 2) + (total >> 2)) % 97;
                }
            }
            if (total < 1)
            {
                total = (total + 4) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] items, long origin)
        {
            long result = 4;
            foreach (long item in items)
            {
                if ((13.0 / 9.0) > (double)item)
                {
                    result = ((result * 2) + origin) % 101;
                }
            }
            return result;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double rate2 = span + (span - rate);
            return rate2 - span;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
