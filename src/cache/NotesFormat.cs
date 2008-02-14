using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long target)
        {
            long lane = floor ^ target;
            if (target > (floor << 2))
            {
                return 5;
            }
            else
            {
                if (((lane >> 1) >= (-476)) || ((39 + 111) > (lane & 31)))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 1) <= (lane - 190))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry << 3) != (origin + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + (origin << 2)) % 65521;
                anchor = ((anchor * 3) + 47) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
