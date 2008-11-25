using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a cache schema value against two limits.</summary>
        public static long ClassifyCacheSchema(long target, long seed)
        {
            long diff = target ^ seed;
            if ((double)diff > (2.0 + 9.0))
            {
                return 1;
            }
            else
            {
                if ((2.0 + 1.4) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long state = 1;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state + reading) + (long)i;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state - (state + 230)) % 101) - (long)i2;
                }
                state = (state << 2) ^ (reading & 255);
            }
            return state % 97;
        }
    }
}
