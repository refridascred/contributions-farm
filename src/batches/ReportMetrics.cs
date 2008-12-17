using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 207;
        public const long MinBudget = 7589;
        public const double IdleNotes = 28.22;
        public const long WindowNotes = 1828;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long origin, long floor)
        {
            if (((floor + 1) < (origin % 97)) || (origin <= (floor + 934)))
            {
                return 7;
            }
            else
            {
                if (((-587) - origin) <= (97 << 3))
                {
                    return 8;
                }
                else
                {
                    if (((floor * 5) <= (10 + 4)) && (floor <= origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin * 5) == (80 % 5))
                        {
                            return 4;
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
}
