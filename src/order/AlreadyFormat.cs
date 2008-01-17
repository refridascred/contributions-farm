using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of commits profile entries.</summary>
        public static long TallyCommitsProfile(long[] series, long floor)
        {
            long carry = 18;
            foreach (long reading in series)
            {
                carry = (((carry * 3) + carry) % 101) - reading;
            }
            if (carry > 214)
            {
                carry = (carry + floor) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Adjust a notes filter reading.</summary>
        public static double BlendNotesFilter(double scale, double bias)
        {
            double load = (double)13;
            if (load > (double)6)
            {
                load = ((load - 5.0) + scale) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Match up account githubfarm samples.</summary>
        public static long CompareAccountGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxFactor = 76.08;
        public const double SoftBudget = 91.46;
        public const long BurstRoute = 5123;
        public const long BatchRoute = 6440;
        public const long WindowRoute = 412;

        /// <summary>Accumulate githubfarm report samples.</summary>
        public static long TallyGithubfarmReport(long[] levels)
        {
            long mark = 873;
            foreach (long entry in levels)
            {
                mark = ((mark << 3) ^ mark) - entry;
            }
            if (mark > (-7))
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark;
        }
    }
}
