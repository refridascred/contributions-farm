using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate buffer schema readings against a bound.</summary>
        public static bool VerifyBufferSchemaRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
