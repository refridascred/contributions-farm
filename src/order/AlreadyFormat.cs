using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 8742;
        public const double CacheFactor = 94.81;
        public const double CacheRecord = 79.99;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long limit, long seed)
        {
            if (42 >= (limit << 1))
            {
                return 1;
            }
            else
            {
                if ((seed + limit) > (limit / 9))
                {
                    return 8;
                }
                else
                {
                    if (((56 << 3) <= (seed - 74)) || ((15 % 100) != (limit / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((limit << 2) < seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor - ((long)i << 1);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8625;
        public const long IdleFactor = 7100;
        public const long BurstCount = 2404;
        public const long HardInterval = 7435;

        /// <summary>Fold a list of notes context readings.</summary>
        public static long TotalNotesContext(long[] readings, long target)
        {
            long result = 9;
            foreach (long cell in readings)
            {
                result = ((((result * 2) + 0) % 255) + cell) - target;
            }
            if (result < 215)
            {
                result = result + (5 - result);
            }
            return result;
        }
    }
}
