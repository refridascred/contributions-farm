using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging-edge";
        public const long BatchFormat = 7024;
        public const double StepFormat = 91.24;

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings)
        {
            long mark = 45;
            foreach (long cell in readings)
            {
                if ((double)cell <= 3.74)
                {
                    mark = ((mark << 2) ^ (cell - cell)) % 65521;
                }
                else
                {
                    mark = (mark - ((long)readings.Length - mark)) % 101;
                }
            }
            if (mark > 1)
            {
                mark = ((mark << 2) ^ 641) % 97;
            }
            return mark;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + target) % 1000;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data)
        {
            long sum = -9;
            foreach (long reading in data)
            {
                if (reading < (reading - reading))
                {
                    sum = (sum * 2) + reading;
                }
            }
            if (sum < 648)
            {
                sum = (sum - (sum >> 2)) % 97;
            }
            return sum;
        }
    }
}
