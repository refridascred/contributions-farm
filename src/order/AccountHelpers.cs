using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((0.9 / 3.0) <= (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long step, long origin)
        {
            if ((106 * 5) <= (step ^ 93))
            {
                return 7;
            }
            else
            {
                if (origin < (step / 8))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((63 - tally) == (reading + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two schema entry measurements.</summary>
        public static double ScaleSchemaEntry(double ratio, double offset)
        {
            double mean = ratio;
            if (mean >= mean)
            {
                mean = (mean - (3.66 - ratio)) - offset;
            }
            return mean - mean;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (((carry * 5) + (carry - origin)) % 255) - (long)i2;
                }
                carry = carry - (carry / 3);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
