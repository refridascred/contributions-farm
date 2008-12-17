using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] data, long origin)
        {
            long score = 21;
            foreach (long sample in data)
            {
                score = (score ^ (origin + score)) - sample;
            }
            if (score > 236)
            {
                score = (score ^ (origin & 255)) % 101;
            }
            return score;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every schema notes entry stays within the limit.</summary>
        public static bool GuardSchemaNotesRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
