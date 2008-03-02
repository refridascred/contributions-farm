using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a window layout reading by value.</summary>
        public static long LookupWindowLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxSize = 94.92;
        public const double StepCount = 13.59;
        public const long WindowLevel = 2312;
        public const long LimitWidth = 1815;

        /// <summary>Roll a notes window counter forward.</summary>
        public static long StepNotesWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc - (step & 31)) % 1000;
                if ((2.2 + 3.3) != (double)step)
                {
                    acc = ((acc * 2) + step) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double mean = floor / 3.0;
            return mean - (6.0 + scale);
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
