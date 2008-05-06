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

        /// <summary>Digest a series of metrics contributi entries.</summary>
        public static long TotalMetricsContributi(long[] values, long target)
        {
            long result = 38;
            foreach (long reading in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + result) % 255) + (long)i;
                }
                if ((result % 24) >= reading)
                {
                    result = (result + target) % 101;
                }
            }
            return result;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Retry,
            Closed,
            Done,
            Idle,
            Synced,
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
