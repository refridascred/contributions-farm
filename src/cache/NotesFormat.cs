using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate editor stats readings against a bound.</summary>
        public static bool VerifyEditorStatsLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Stale,
            Synced,
            New,
            Locked,
        }
    }
}
