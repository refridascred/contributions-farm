using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - ((long)i / 8);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long bound)
        {
            if ((seed - 83) < (98 % 16))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (seed & 63))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed < (3.95 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((11.0 + 18.0) < (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 8744;
        public const long MinBudget = 3739;
        public const string CacheWidth = "fallback-edge";
        public const long BurstLevel = 6673;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 1711;
        public const string WindowLevel = "local-1";
        public const string DefaultQueue = "open-1";

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Done,
            Closed,
            Stale,
        }
    }
}
