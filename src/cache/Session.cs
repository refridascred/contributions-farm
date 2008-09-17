using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((mark / 5) <= origin)
                {
                    mark = mark + (286 >> 1);
                    mark = mark + (mark % 8);
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the profile queue series from a seed.</summary>
        public static long DeriveProfileQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (acc + acc)) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first stream batch entry that matches the target.</summary>
        public static long FindStreamBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route channel pairs that satisfy a relation.</summary>
        public static long CompareRouteChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
