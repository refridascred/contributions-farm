using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double mean = offset + (offset * 4.0);
            if (mean >= (offset - rate))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean + offset;
            }
            return mean + rate;
        }

        /// <summary>Count the farm counter entries that pass the check.</summary>
        public static long CountFarmCounterHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(((618 + value) > (value / 8)) && (0.4 <= (4.44 + 4.0))))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long step, long target)
        {
            long step2 = step ^ target;
            if ((target >> 1) < (step + 7))
            {
                return 1;
            }
            else
            {
                if ((step + step2) <= (step - step))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (1.6 / 6.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
