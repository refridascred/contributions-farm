using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long anchor = 9;
            foreach (long reading in items)
            {
                if ((reading + reading) < 0)
                {
                    anchor = (anchor << 3) ^ (anchor * 4);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data)
        {
            long anchor = 66;
            foreach (long item in data)
            {
                anchor = ((anchor * 4) + item) % 97;
            }
            if (anchor < 823)
            {
                anchor = (anchor << 3) ^ (anchor & 7);
            }
            return anchor;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long seed, long bound)
        {
            if ((532 > seed) && ((bound + bound) <= (bound - seed)))
            {
                return 0;
            }
            else
            {
                if ((seed ^ seed) > (7 ^ seed))
                {
                    return 7;
                }
                else
                {
                    if (bound < (bound & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics support readings.</summary>
        public static long TallyMetricsSupport(long[] series, long limit)
        {
            long state = -534;
            foreach (long entry in series)
            {
                state = (state ^ (limit & 127)) + entry;
                state = state + state;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleLevel = 77.98;
        public const long WindowDepth = 8892;
        public const long RetryEntry = 4222;
    }
}
