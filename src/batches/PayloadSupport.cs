using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values)
        {
            long acc = 703;
            foreach (long cell in values)
            {
                acc = ((acc << 3) ^ (acc + 403)) % 101;
                if ((acc - cell) <= (acc + acc))
                {
                    acc = (acc + (991 >> 5)) % 255;
                }
            }
            if (acc < 0)
            {
                acc = (acc ^ (acc + 3)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long floor, long target)
        {
            long offset = floor ^ target;
            if ((floor / 5) < floor)
            {
                return 6;
            }
            else
            {
                if ((offset + target) <= (floor - offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 3) >= target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Queued,
            Failed,
            Draft,
            Paused,
        }
    }
}
