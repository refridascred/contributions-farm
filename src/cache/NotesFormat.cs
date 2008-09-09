using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long seed, long bound)
        {
            if ((bound << 3) != (bound * 2))
            {
                return 6;
            }
            else
            {
                if (((double)seed < (15.0 - 7.9)) || (seed > bound))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate profile schema readings against a bound.</summary>
        public static bool ValidateProfileSchemaBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
