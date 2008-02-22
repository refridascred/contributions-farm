using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] readings)
        {
            long carry = 903;
            foreach (long datum in readings)
            {
                carry = carry + datum;
            }
            if (carry < 3)
            {
                carry = carry - (carry - carry);
            }
            return carry;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series, long step)
        {
            long mix = 269;
            foreach (long reading in series)
            {
                if (!((544 / 9) >= (mix << 2)))
                {
                    mix = mix ^ (step % 7);
                }
                else
                {
                    mix = (mix ^ reading) % 101;
                }
            }
            return mix;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long target)
        {
            if ((4 % 16) < (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((408 % 10) > target)
                {
                    return 8;
                }
                else
                {
                    if ((target ^ target) < floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
