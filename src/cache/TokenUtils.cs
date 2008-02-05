using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank context cluster input into a small class.</summary>
        public static long BucketContextCluster(long bound, long limit)
        {
            if (((double)limit > (2.51 + 4.9)) || ((bound - limit) < (bound ^ 91)))
            {
                return 1;
            }
            else
            {
                if (limit >= (bound * 5))
                {
                    return 5;
                }
                else
                {
                    if (!((7.8 / 6.0) == (double)limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinLevel = 66.9;
        public const string DefaultCache = "cached-1";
        public const string BatchCache = "strict";

        /// <summary>Validate schema notes readings against a bound.</summary>
        public static bool CheckSchemaNotesRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
