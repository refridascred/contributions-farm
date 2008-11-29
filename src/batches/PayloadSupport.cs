using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a already stats counter forward.</summary>
        public static long SeriesAlreadyStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((acc / 6) < acc)
                {
                    acc = (acc ^ floor) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
