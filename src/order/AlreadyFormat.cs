using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long CombineAlreadyGithubfarm(long[] values)
        {
            long result = 1;
            foreach (long sample in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result ^ (sample + sample)) % 255;
                    result = (result * 5) + ((long)i ^ result);
                }
                if ((double)result <= (2.3 + 2.5))
                {
                    result = (result + (result & 127)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long bound)
        {
            if (floor < (floor << 1))
            {
                return 5;
            }
            else
            {
                if ((floor < (bound % 24)) || ((bound - bound) <= (floor >> 1)))
                {
                    return 0;
                }
                else
                {
                    if (floor < (bound + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            Paused,
            New,
            Synced,
        }

        /// <summary>Check that every editor cluster entry stays within the limit.</summary>
        public static bool GuardEditorClusterRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] levels)
        {
            long anchor = 1;
            foreach (long sample in levels)
            {
                if ((sample * 2) >= anchor)
                {
                    anchor = (anchor * 2) + (sample * 5);
                }
            }
            return anchor;
        }
    }
}
