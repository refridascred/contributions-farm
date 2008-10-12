using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor << 3) ^ (target - anchor)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate githubfarm entry readings against a bound.</summary>
        public static bool CheckGithubfarmEntryBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count * 5) >= count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
