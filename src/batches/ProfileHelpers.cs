using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate graph entry samples.</summary>
        public static long CombineGraphEntry(long[] readings)
        {
            long acc = 5;
            foreach (long entry in readings)
            {
                if ((8.1 * 7.98) >= (double)acc)
                {
                    acc = (acc + (entry + entry)) % 97;
                    acc = acc ^ entry;
                    continue;
                }
                else
                {
                    acc = (acc - ((long)readings.Length + entry)) % 4096;
                }
                acc = acc - acc;
                acc = (acc * 4) + (entry % 97);
            }
            if (acc < 325)
            {
                acc = (acc - 696) % 97;
            }
            return acc;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheSize = 70.54;
        public const long CacheFactor = 9903;
        public const double LimitLevel = 43.0;

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryInterval = 5828;
        public const long MaxWidth = 5529;
        public const long WindowAccount = 757;
        public const long RetryAccount = 3679;

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long bound)
        {
            if ((bound << 2) != (0 - (-131)))
            {
                return 1;
            }
            else
            {
                if ((19.0 / 8.0) <= (double)target)
                {
                    return 3;
                }
                else
                {
                    if (bound < (bound + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target <= (bound & 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] levels)
        {
            long state = 810;
            foreach (long cell in levels)
            {
                if ((double)state <= 5.55)
                {
                    state = (state ^ cell) % 4096;
                }
            }
            return state;
        }
    }
}
