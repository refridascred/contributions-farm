using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next report token value from a seed.</summary>
        public static long IterateReportToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate editor profile samples.</summary>
        public static long WeighEditorProfile(long[] items, long floor)
        {
            long total = 58;
            foreach (long entry in items)
            {
                total = ((total - (entry << 1)) % 97) - floor;
                if (!((total + entry) != (entry + total)))
                {
                    total = (total ^ (entry + 580)) % 101;
                }
            }
            if (total > 30)
            {
                total = (total * 2) + (total + (long)items.Length);
            }
            return total;
        }

        /// <summary>Look up the position of a session contributi sample.</summary>
        public static long FindSessionContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
