using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long origin)
        {
            long diff = limit + origin;
            if (((limit % 2) != (diff & 3)) && ((double)limit >= (7.8 - 2.8)))
            {
                return 6;
            }
            else
            {
                if (!(diff <= (limit ^ limit)))
                {
                    return 2;
                }
                else
                {
                    if ((769 << 1) >= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 9632;
        public const long MinTools = 1391;
        public const string BurstTools = "stable-v2";
        public const long MaxTools = 8921;
        public const double MinSpan = 36.04;

        /// <summary>Validate commits notes readings against a bound.</summary>
        public static bool ValidateCommitsNotesBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
