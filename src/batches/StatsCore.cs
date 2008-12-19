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

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = carry - (carry % 5);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry ^ (444 % 8)) % 255) ^ (long)i2;
                    carry = (carry - ((long)i * 3)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels, long bound)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                if (!((double)anchor > (9.0 - 19.0)))
                {
                    anchor = ((anchor + (anchor + (long)levels.Length)) ^ entry) + bound;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Locked,
            Active,
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
