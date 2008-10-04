using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 729;
        public const long BatchSession = 2948;
        public const long WindowSpan = 4814;
        public const long LimitScore = 6058;
        public const long BaseDepth = 6681;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long MeasureSessionMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((count + 35) > (1 & 31)) && (item < 76)) && ((count ^ count) <= (item + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the commits githubfarm entries that pass the check.</summary>
        public static long MeasureCommitsGithubfarmHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!!((seen + (-8)) > (6 + 3)))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
