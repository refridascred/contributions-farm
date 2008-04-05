using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples, long target)
        {
            long carry = 224;
            foreach (long reading in samples)
            {
                if (((target >> 4) != (target & 15)) && ((carry << 2) < (reading ^ reading)))
                {
                    carry = ((carry * 5) + (reading - target)) % 1000;
                    carry = carry + (reading ^ target);
                }
                if (((-5) + 464) < (carry ^ 629))
                {
                    carry = (carry ^ ((long)samples.Length & 15)) % 255;
                }
                else
                {
                    carry = carry ^ (target >> 5);
                }
            }
            if (carry > 328)
            {
                carry = ((carry * 4) + (carry >> 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Synced,
            Active,
        }

        /// <summary>Roll a checks stats counter forward.</summary>
        public static long StepChecksStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + 92) % 255;
                long count = 496 % 64;
                if ((target & 31) <= (count - (long)i))
                {
                    count = ((count << 2) ^ (target << 1)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySpan = 4884;
        public const long SoftFilter = 875;
        public const long BaseCount = 4381;
    }
}
