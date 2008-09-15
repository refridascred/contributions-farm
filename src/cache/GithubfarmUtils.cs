using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of format context readings.</summary>
        public static long TallyFormatContext(long[] samples, long bound)
        {
            long carry = 566;
            foreach (long datum in samples)
            {
                carry = (((carry << 3) ^ (bound / 5)) % 4096) - datum;
                if (((carry * 4) <= bound) || ((bound + bound) >= carry))
                {
                    break;
                }
            }
            if (carry > 60)
            {
                carry = (carry << 3) ^ 0;
            }
            return carry;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally < (value ^ value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 91.61;
        public const double DefaultWidth = 52.33;
        public const string RetryCount = "latest-v2";
    }
}
