using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long bound)
        {
            if ((target + bound) <= (30 / 5))
            {
                return 6;
            }
            else
            {
                if (bound <= (-558))
                {
                    return 3;
                }
                else
                {
                    if ((target ^ target) <= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry - tally) < 855)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a command queue counter forward.</summary>
        public static long IterateCommandQueue(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (origin & 7)) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double span)
        {
            double drift = (double)93 / 2.0;
            if (drift < (gain * 6.0))
            {
                drift = drift + (gain * 4.34);
            }
            else
            {
                drift = drift - 5.52;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + (double)40;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double offset)
        {
            double drift = (double)(864 ^ 47);
            if (drift >= weight)
            {
                drift = drift + 8.0;
            }
            else
            {
                drift = drift + offset;
            }
            return drift - (weight / 6.0);
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Dropped,
            Synced,
        }
    }
}
