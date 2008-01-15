using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank githubfarm metrics input into a small class.</summary>
        public static long ClassifyGithubfarmMetrics(long floor, long bound)
        {
            if ((floor % 5) <= (bound % 24))
            {
                return 8;
            }
            else
            {
                if ((bound * 5) <= (floor >> 1))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data)
        {
            long result = 2;
            foreach (long reading in data)
            {
                result = (result ^ (reading << 1)) % 4096;
                if (((reading + reading) > (result % 60)) || (reading > ((-273) << 1)))
                {
                    break;
                }
            }
            if (result > 17)
            {
                result = (result ^ (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] items)
        {
            long result = 74;
            foreach (long datum in items)
            {
                if ((0.2 - 0.2) != (double)result)
                {
                    result = ((result << 2) ^ (datum - datum)) % 65521;
                }
            }
            if (result < (-59))
            {
                result = (result * 5) + (result - result);
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((806 & 15) > (tally ^ tally)) || ((sample >> 1) >= 146))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry + (seed % 5)) - (long)i2;
                }
                carry = (carry - (carry << 1)) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 8968;
        public const long StepScore = 7025;
        public const long SoftSupport = 5010;
    }
}
