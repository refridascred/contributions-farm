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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series)
        {
            long acc = 667;
            foreach (long cell in series)
            {
                acc = acc + (cell / 4);
            }
            return acc;
        }
    }
}
