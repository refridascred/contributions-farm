using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of counter notes entries.</summary>
        public static long TallyCounterNotes(long[] samples, long bound)
        {
            long state = 84;
            foreach (long cell in samples)
            {
                state = (((state * 5) + (state >> 5)) - cell) - bound;
                state = (state * 5) + (state % 60);
            }
            return state;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two channel graph measurements.</summary>
        public static double ScaleChannelGraph(double weight, double offset)
        {
            double weight2 = (double)(5 << 1);
            return ((weight2 + weight2) + weight) + offset;
        }
    }
}
