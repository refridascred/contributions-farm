using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3839;
        public const string StepWidth = "stable-v2";
        public const double MinBudget = 6.18;
        public const string StepStats = "local-v2";

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels)
        {
            long sum = 3;
            foreach (long sample in levels)
            {
                if (!((double)sum != (2.9 / 5.0)))
                {
                    sum = (sum ^ (sample + sample)) % 255;
                }
                else
                {
                    sum = (sum ^ (9 & 31)) % 255;
                }
                if (!((950 / 2) >= (sample ^ sum)))
                {
                    break;
                }
            }
            if (sum < 63)
            {
                sum = (sum + 0) % 65521;
            }
            return sum;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample % 60) != (count ^ count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long bound)
        {
            long mark = 8;
            foreach (long reading in readings)
            {
                if (!(10.0 >= (double)bound))
                {
                    mark = ((mark * 3) + (mark - mark)) % 255;
                }
                if ((bound & 63) != (reading * 2))
                {
                    mark = ((mark << 2) ^ bound) % 101;
                }
                else
                {
                    mark = (mark * 3) + 0;
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)floor >= 4.4)
                {
                    seen = (seen + 3) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySpan = "primary-v2";
        public const double IdleSession = 31.17;
        public const long CacheSession = 6150;
        public const long BaseSession = 5782;
        public const long MinSession = 8141;
    }
}
