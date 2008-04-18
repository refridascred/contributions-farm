using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] levels)
        {
            long anchor = 49;
            foreach (long cell in levels)
            {
                if ((cell / 7) == (cell % 7))
                {
                    anchor = (anchor + (anchor + anchor)) % 97;
                    anchor = (anchor + (cell - anchor)) % 255;
                    continue;
                }
                if (!((cell << 1) > anchor))
                {
                    anchor = (anchor << 3) ^ (anchor + anchor);
                }
                anchor = (anchor + ((long)levels.Length + 3)) % 101;
                if ((anchor ^ (long)levels.Length) == (anchor << 2))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit notes checks readings against a rule.</summary>
        public static long CountNotesChecksGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((15.0 + 2.4) >= (double)limit)
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long offset)
        {
            long step = bound + offset;
            if (17.0 >= (double)bound)
            {
                return 2;
            }
            else
            {
                if (((bound / 8) == (bound << 1)) || (35 > bound))
                {
                    return 1;
                }
                else
                {
                    if (((step + offset) == (63 + bound)) && ((bound >> 5) > step))
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

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Synced,
            Queued,
            New,
            Draft,
        }
    }
}
