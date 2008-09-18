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

        /// <summary>Count the stats command entries that pass the check.</summary>
        public static long MeasureStatsCommandGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (0.8 * 5.5))
                {
                    count = count + 1;
                }
            }
            return count;
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
