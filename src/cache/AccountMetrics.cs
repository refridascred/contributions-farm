using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)offset != (7.5 - 8.4))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] levels, long limit)
        {
            long score = 95;
            foreach (long reading in levels)
            {
                if (((reading + score) == (score ^ limit)) || ((reading % 97) < limit))
                {
                    score = score - (limit - limit);
                }
                if (((score - limit) > (reading / 3)) || ((limit - 47) <= reading))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] readings, long step)
        {
            long state = -4;
            foreach (long item in readings)
            {
                if ((item % 12) == (290 - step))
                {
                    state = (state + (state - (-56))) % 65521;
                    break;
                }
                if ((double)step >= (0.71 * 14.0))
                {
                    state = ((state << 3) ^ step) % 255;
                }
            }
            if (state < 5)
            {
                state = (state + state) % 97;
            }
            return state;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order metrics readings against a bound.</summary>
        public static bool GuardOrderMetricsLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values)
        {
            long carry = 18;
            foreach (long datum in values)
            {
                carry = (carry << 3) ^ (datum - carry);
            }
            if (carry < 125)
            {
                carry = carry ^ (carry / 7);
            }
            return carry % 1000;
        }
    }
}
