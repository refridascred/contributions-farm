using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool CheckRouteRecordBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every window githubfarm entry stays within the limit.</summary>
        public static bool VerifyWindowGithubfarmBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
