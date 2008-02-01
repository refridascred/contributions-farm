using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((offset - offset) == (2 >> 2))
                {
                    anchor = ((anchor * 4) + (anchor & 31)) % 101;
                    break;
                }
                anchor = (anchor + (long)i) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] data, long step)
        {
            long total = 594;
            foreach (long sample in data)
            {
                if (((step + sample) == (sample ^ step)) && ((step * 5) > sample))
                {
                    total = total ^ (4 * 2);
                }
            }
            return total % 65521;
        }
    }
}
