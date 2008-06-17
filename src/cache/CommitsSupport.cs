using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchInterval = 9973;
        public const double BaseEditor = 24.5;
        public const long MaxEditor = 6078;
        public const long RetryEditor = 2617;
        public const double MinSize = 73.64;

        /// <summary>Find the first buffer context entry that matches the target.</summary>
        public static long LookupBufferContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((tally / 8) == (target - reading)) || (target > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data, long target)
        {
            long carry = 357;
            foreach (long datum in data)
            {
                carry = ((carry - (target >> 3)) % 1000) - datum;
            }
            if (carry > 1)
            {
                carry = carry - (target % 8);
            }
            return carry;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count >> 3) != (count >> 4))
                {
                    count = ((count + 2) + sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double ratio = 12.0 / 4.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + offset;
            }
            return ratio - gain;
        }
    }
}
