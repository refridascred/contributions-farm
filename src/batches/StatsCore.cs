using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((origin << 2) < (45 << 2))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits ^ hits) > (value << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a counter order pair into a bucket.</summary>
        public static long GradeCounterOrder(long limit, long limit2)
        {
            long step = limit - limit2;
            if ((52 * 3) > (limit * 5))
            {
                return 2;
            }
            else
            {
                if (!((step / 5) > step))
                {
                    return 3;
                }
                else
                {
                    if (limit2 <= (step + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                long next = carry;
                if (seed < (carry ^ next))
                {
                    carry = carry - (next ^ seed);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
