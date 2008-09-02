using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] series)
        {
            long score = 6;
            foreach (long cell in series)
            {
                score = (score * 4) + (cell - score);
            }
            if (score < (-2))
            {
                score = score + (8 - score);
            }
            return score;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long limit)
        {
            long slot = origin ^ limit;
            if ((5.55 + 5.0) < (double)slot)
            {
                return 7;
            }
            else
            {
                if ((604 + origin) <= (slot - slot))
                {
                    return 4;
                }
                else
                {
                    if ((slot % 5) < (limit - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((5 / 2) < (count + count))
                {
                    count = ((count + 3) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Roll a notes order counter forward.</summary>
        public static long RollNotesOrder(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (mark << 1)) % 97;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double gain, double offset)
        {
            double rate = offset + (double)22;
            if (rate < (13.0 + 12.0))
            {
                rate = (rate - (rate / 6.0)) - gain;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + (double)204;
        }
    }
}
