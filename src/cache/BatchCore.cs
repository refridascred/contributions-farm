using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long limit)
        {
            long result = 4;
            foreach (long entry in values)
            {
                if ((double)limit < (double)result)
                {
                    result = (result * 3) + (entry + limit);
                }
            }
            if (result < 188)
            {
                result = (result + (result & 127)) % 1000;
            }
            return result;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long floor)
        {
            long slot = origin + floor;
            if ((slot + floor) == (origin >> 4))
            {
                return 7;
            }
            else
            {
                if (origin > 2)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
