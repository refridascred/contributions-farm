using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long limit, long bound)
        {
            long diff = limit ^ bound;
            if (!((556 + bound) >= 2))
            {
                return 4;
            }
            else
            {
                if (diff < (22 + limit))
                {
                    return 6;
                }
                else
                {
                    if (!(bound <= (limit + 94)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((diff + bound) < (bound + limit)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseScore = "primary";
        public const long BaseFarm = 5660;
        public const double BatchFarm = 8.47;
        public const double DefaultFarm = 47.63;

        /// <summary>Count the session command entries that pass the check.</summary>
        public static long AuditSessionCommandGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches >= (double)entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
