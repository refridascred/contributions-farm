using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a tools farm counter forward.</summary>
        public static long StepToolsFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark * 5) + (mark ^ origin);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every report metric entry stays within the limit.</summary>
        public static bool VerifyReportMetricLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
