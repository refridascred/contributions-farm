using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Describe the booking phase values.</summary>
        public enum BookingPhase
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] values, long offset)
        {
            long sum = 80;
            foreach (long datum in values)
            {
                sum = ((sum - (sum + 4)) % 1000) ^ datum;
                if ((double)(long)values.Length >= (3.23 * 9.7))
                {
                    sum = sum ^ (offset + (-77));
                }
            }
            return sum % 65521;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long seed, long offset)
        {
            long span = seed - offset;
            if (((9.92 - 2.7) >= (double)seed) || ((seed - seed) > (span - span)))
            {
                return 7;
            }
            else
            {
                if ((712 + offset) != (span * 5))
                {
                    return 8;
                }
                else
                {
                    if ((4.4 - 0.5) > (double)span)
                    {
                        return 2;
                    }
                    else
                    {
                        if (18.0 > (double)span)
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
        }
    }
}
