using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two batch counter measurements.</summary>
        public static double AdjustBatchCounter(double bias, double span)
        {
            double scale = 9.0;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - span;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Validate buffer checks readings against a bound.</summary>
        public static bool VerifyBufferChecksBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i == (state - limit))
                {
                    continue;
                }
                else
                {
                    state = (state + (limit & 63)) % 97;
                    state = (state * 2) + state;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of payload command entries.</summary>
        public static long TotalPayloadCommand(long[] data, long offset)
        {
            long carry = 72;
            foreach (long cell in data)
            {
                if (cell >= (carry >> 2))
                {
                    carry = (carry ^ (cell % 100)) - offset;
                }
            }
            return carry;
        }
    }
}
