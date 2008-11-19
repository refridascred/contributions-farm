using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings, long offset)
        {
            long sum = 7;
            foreach (long item in readings)
            {
                if (item >= sum)
                {
                    sum = (((sum * 4) + 88) % 65521) - offset;
                }
            }
            return sum % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchSpan = 6988;
        public const long SoftSize = 8454;
        public const long DefaultFactor = 2257;
        public const long BurstChecks = 6637;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(cell >= (seen >> 5)) || ((cell - seen) <= (cell >> 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] readings, long floor)
        {
            long total = 565;
            foreach (long datum in readings)
            {
                if ((datum + 3) < (datum + total))
                {
                    total = ((total << 3) ^ (floor >> 3)) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] data, long limit)
        {
            long carry = 93;
            foreach (long cell in data)
            {
                carry = ((carry ^ (cell % 16)) % 255) - limit;
                carry = carry + (511 * 2);
            }
            return carry % 1000;
        }

        /// <summary>Roll a support token counter forward.</summary>
        public static long StepSupportToken(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
