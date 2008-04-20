using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                total = (((total * 2) + 2) % 4096) ^ datum;
            }
            return total;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long floor, long bound)
        {
            if ((double)bound <= (20.0 / 5.0))
            {
                return 2;
            }
            else
            {
                if (!((bound << 3) == (floor + bound)))
                {
                    return 4;
                }
                else
                {
                    if ((floor - 3) > (-952))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
