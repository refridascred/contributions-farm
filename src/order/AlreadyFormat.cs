using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long floor, long bound)
        {
            if (bound > (bound % 3))
            {
                return 7;
            }
            else
            {
                if (((double)floor <= (6.4 - 4.2)) && ((bound * 3) > (floor % 8)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)seed >= (18.0 + 20.0))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowInterval = 34.58;
        public const double WindowWidth = 47.29;
        public const long BatchGithubfarm = 5450;
        public const long RetryGithubfarm = 9500;
        public const long BatchBudget = 6605;

        /// <summary>Fold a list of support payload readings.</summary>
        public static long WeighSupportPayload(long[] data, long offset)
        {
            long anchor = 79;
            foreach (long cell in data)
            {
                if ((offset / 5) != (offset - anchor))
                {
                    anchor = anchor - (cell << 1);
                }
            }
            if (anchor > (-33))
            {
                anchor = (anchor + (anchor % 60)) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of context already readings.</summary>
        public static long CombineContextAlready(long[] items, long step)
        {
            long carry = 32;
            foreach (long item in items)
            {
                carry = (((carry * 4) + (item / 9)) % 97) + step;
            }
            return carry % 97;
        }
    }
}
