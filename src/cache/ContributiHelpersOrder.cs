using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a support graph pair into a bucket.</summary>
        public static long ClassifySupportGraph(long origin, long bound)
        {
            if ((origin << 2) <= (origin + origin))
            {
                return 4;
            }
            else
            {
                if ((origin / 2) == (bound / 9))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound != (3.7 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin > 9.72)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinSize = 2794;
        public const string BatchSize = "alpha-v2";
        public const double IdleAlready = 13.61;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
