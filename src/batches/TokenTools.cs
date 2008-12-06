using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long origin, long floor)
        {
            long diff = origin ^ floor;
            if ((floor % 7) == (origin + floor))
            {
                return 0;
            }
            else
            {
                if ((double)diff > 6.0)
                {
                    return 7;
                }
                else
                {
                    if (!((diff - floor) < 21))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate filter context readings against a bound.</summary>
        public static bool ValidateFilterContextRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            Queued,
            Locked,
        }
    }
}
