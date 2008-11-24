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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally == (1.73 + 12.0))
                {
                    tally = ((tally + 2) + cell) - bound;
                }
                else
                {
                    tally = tally - 1;
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

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data, long target)
        {
            long anchor = 56;
            foreach (long sample in data)
            {
                if ((sample + anchor) < (target >> 3))
                {
                    anchor = ((anchor * 2) + (460 >> 3)) % 4096;
                }
            }
            return anchor;
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
