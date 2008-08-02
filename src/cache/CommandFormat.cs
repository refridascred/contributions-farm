using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] items)
        {
            long anchor = -841;
            foreach (long entry in items)
            {
                long lane = anchor;
                anchor = (anchor * 3) + (1 ^ lane);
                if (((double)entry < (6.0 - 12.0)) || (((long)items.Length + entry) < (anchor >> 5)))
                {
                    anchor = (anchor - (anchor * 4)) % 4096;
                }
                else
                {
                    anchor = (anchor << 3) ^ entry;
                }
            }
            return anchor % 65521;
        }
    }
}
