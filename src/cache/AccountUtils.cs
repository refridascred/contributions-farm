using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample + 86) <= (tally + bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
