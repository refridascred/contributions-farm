using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a filter batch value against two limits.</summary>
        public static long GradeFilterBatch(long origin, long floor)
        {
            long step = origin - floor;
            if ((double)floor < (6.07 + 9.11))
            {
                return 1;
            }
            else
            {
                if (((step >> 4) > (origin & 255)) && (9.0 > (double)origin))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
