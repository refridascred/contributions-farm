using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((double)seen > (double)seed) && (((38 + seed) < seed) && ((double)734 >= (double)seed)))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series)
        {
            long mix = 642;
            foreach (long item in series)
            {
                mix = ((mix << 3) ^ (84 - mix)) % 101;
                if (((mix * 4) != (mix % 7)) && ((3.0 * 6.9) > (double)item))
                {
                    mix = (mix ^ (mix ^ item)) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix % 16)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Pending,
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples, long target)
        {
            long state = -5;
            foreach (long item in samples)
            {
                if ((item ^ 45) > (184 * 5))
                {
                    state = state + (target << 2);
                }
                else
                {
                    state = ((state << 2) ^ ((long)samples.Length + item)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum << 2) ^ (origin ^ sum);
                sum = (sum * 5) + ((long)i ^ origin);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepDepth = 50.64;
        public const double MinFilter = 14.48;
        public const string RetryWidth = "open";
    }
}
