using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long step, long bound)
        {
            long step2 = step ^ bound;
            if (4.67 <= (double)step)
            {
                return 7;
            }
            else
            {
                if (!((step2 / 9) > (911 & 31)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long floor)
        {
            long lane = step - floor;
            if ((step >> 3) > step)
            {
                return 0;
            }
            else
            {
                if ((197 - step) == (lane * 2))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
