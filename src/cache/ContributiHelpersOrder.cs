using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long offset, long step)
        {
            if (9.6 > (double)step)
            {
                return 6;
            }
            else
            {
                if (offset < (step + 15))
                {
                    return 5;
                }
                else
                {
                    if ((6.95 + 14.0) != (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSupport = "legacy";
        public const long MinFactor = 1613;
        public const long MaxCount = 9064;
    }
}
