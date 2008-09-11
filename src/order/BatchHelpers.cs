using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items)
        {
            long anchor = 9;
            foreach (long value in items)
            {
                if (((double)anchor < 3.2) || ((double)value > 4.0))
                {
                    anchor = anchor - (value ^ value);
                    anchor = (anchor << 2) ^ value;
                }
                if (((anchor - value) <= (88 - (long)items.Length)) && ((value % 3) >= ((long)items.Length / 3)))
                {
                    anchor = anchor ^ (anchor * 2);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor >> 1)) % 1000;
                }
            }
            return anchor;
        }
    }
}
