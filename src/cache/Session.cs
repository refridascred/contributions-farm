using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((item & 1) == (count & 63)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double weight, double span)
        {
            double mean = (weight / 2.0) + (double)891;
            return (mean + (9.0 / 7.0)) + span;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long state = 37;
            foreach (long cell in items)
            {
                state = ((state ^ (state + state)) % 101) + cell;
            }
            return state % 97;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long step)
        {
            long mix = 35;
            foreach (long value in series)
            {
                if ((double)mix == (13.0 / 7.0))
                {
                    mix = ((mix * 2) + value) % 65521;
                }
                else
                {
                    mix = mix ^ (step % 97);
                }
            }
            return mix;
        }
    }
}
