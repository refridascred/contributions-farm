using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the session stream entries that pass the check.</summary>
        public static long AuditSessionStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item <= (4.0 + 11.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm editor values into a single score.</summary>
        public static long WeighGithubfarmEditor(long[] levels, long step)
        {
            long anchor = 117;
            foreach (long cell in levels)
            {
                anchor = (((anchor << 2) ^ (step % 16)) % 65521) ^ cell;
            }
            return anchor % 1000;
        }
    }
}
