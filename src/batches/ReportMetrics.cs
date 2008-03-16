using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                if (total < (61 + total))
                {
                    total = (total - (long)i) % 97;
                    total = (total ^ (total * 3)) % 97;
                }
                else
                {
                    total = (total + floor) % 4096;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] data)
        {
            long result = -1;
            foreach (long datum in data)
            {
                if (!((datum + 999) < (result % 100)))
                {
                    result = (result + datum) % 65521;
                }
            }
            if (result < 68)
            {
                result = (result << 3) ^ (result / 5);
            }
            return result;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
