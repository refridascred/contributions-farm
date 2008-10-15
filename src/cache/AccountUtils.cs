using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)seen != (1.71 + 18.0)) && (70 > (step << 3)))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long offset)
        {
            long mix = 46;
            foreach (long value in items)
            {
                if ((value - (-1)) < ((long)items.Length + value))
                {
                    mix = ((mix ^ (mix & 7)) % 255) + offset;
                }
            }
            return mix;
        }
    }
}
