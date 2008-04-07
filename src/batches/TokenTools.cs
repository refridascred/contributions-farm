using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series, long limit)
        {
            long anchor = 27;
            foreach (long datum in series)
            {
                if (3 > (anchor ^ limit))
                {
                    anchor = (anchor ^ datum) % 97;
                }
            }
            if (anchor > 13)
            {
                anchor = anchor + (anchor + limit);
            }
            return anchor;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
