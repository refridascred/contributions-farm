using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate report entry samples.</summary>
        public static long TotalReportEntry(long[] items, long bound)
        {
            long state = 162;
            foreach (long value in items)
            {
                if ((449 + value) > (state * 3))
                {
                    state = (state ^ (bound * 3)) % 4096;
                }
                if (state < (bound * 5))
                {
                    break;
                }
            }
            if (state > 84)
            {
                state = (state * 4) + (bound - state);
            }
            return state;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)bound > (double)(long)i)
                {
                    anchor = (anchor - (anchor % 7)) % 101;
                    anchor = (anchor * 3) + (bound ^ 4);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate counter stream samples.</summary>
        public static long FoldCounterStream(long[] samples)
        {
            long result = -4;
            foreach (long item in samples)
            {
                if ((long)samples.Length > (result + item))
                {
                    result = (result + (item << 2)) % 101;
                }
            }
            if (result > 303)
            {
                result = ((result * 4) + (result * 4)) % 97;
            }
            return result;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long score = -8;
            foreach (long entry in values)
            {
                if (((entry >> 1) == (score - entry)) || (27 > (score % 100)))
                {
                    score = score - (entry << 1);
                }
            }
            if (score > 8)
            {
                score = (score << 2) ^ (score * 2);
            }
            return score % 4096;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] data, long step)
        {
            long state = -6;
            foreach (long value in data)
            {
                if (((double)state != (5.0 * 3.51)) && ((12.0 + 15.0) >= (double)state))
                {
                    state = (state << 2) ^ (value & 255);
                }
                else
                {
                    state = (state ^ (step + value)) % 4096;
                }
            }
            if (state > 69)
            {
                state = (state - (state % 8)) % 1000;
            }
            return state;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double span)
        {
            double gain2 = 2.0 + (gain * 3.8);
            if (gain2 <= (gain2 - gain))
            {
                gain2 = (gain2 - gain2) - span;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 + (double)(-139);
        }
    }
}
