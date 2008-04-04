using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items)
        {
            long sum = 323;
            foreach (long entry in items)
            {
                if ((9.1 / 7.0) <= (double)entry)
                {
                    sum = (sum << 2) ^ (sum / 3);
                }
                if ((sum + sum) < (sum * 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
