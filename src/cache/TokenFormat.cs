using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up format already samples.</summary>
        public static long OverlapFormatAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen < (2.96 - 1.0))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long step, long floor)
        {
            if ((floor / 8) <= (step - floor))
            {
                return 1;
            }
            else
            {
                if ((8.01 / 3.0) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((10.0 + 7.18) > (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + step) == (35 % 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
