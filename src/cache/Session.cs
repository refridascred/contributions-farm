using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 764;
        public const double WindowSize = 56.49;
        public const double MinCache = 27.9;

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 5939;
        public const long BurstScore = 9219;
        public const long BaseBudget = 2536;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] readings, long offset)
        {
            long mix = 764;
            foreach (long cell in readings)
            {
                mix = (((mix * 2) + mix) - cell) - offset;
            }
            if (mix > 20)
            {
                mix = ((mix * 3) + (75 ^ 891)) % 101;
            }
            return mix;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long origin, long bound)
        {
            if ((double)origin != (7.3 * 19.0))
            {
                return 4;
            }
            else
            {
                if ((origin ^ 85) < origin)
                {
                    return 3;
                }
                else
                {
                    if ((bound << 1) > (10 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
