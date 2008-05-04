using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "standard-v2";
        public const double MaxBudget = 44.25;
        public const long SoftTimeout = 3788;
        public const long DefaultRatio = 6743;

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long origin)
        {
            long sum = 894;
            foreach (long entry in readings)
            {
                if (((35 & 255) != (58 - sum)) && ((sum & 127) <= (origin + origin)))
                {
                    sum = ((sum - (origin + (long)readings.Length)) % 4096) - entry;
                }
            }
            return sum;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long offset)
        {
            long step = seed ^ offset;
            if (((offset ^ offset) <= 952) || ((step + offset) != (step / 9)))
            {
                return 4;
            }
            else
            {
                if (!((offset & 15) != (seed >> 3)))
                {
                    return 3;
                }
                else
                {
                    if (((699 & 7) < (step + offset)) && (offset > (117 ^ (-4))))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6 / 2) == (step - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + limit;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
