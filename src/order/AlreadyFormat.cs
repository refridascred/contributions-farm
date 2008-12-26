using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine filter contributi values into a single score.</summary>
        public static long ScoreFilterContributi(long[] series, long floor)
        {
            long acc = -986;
            foreach (long reading in series)
            {
                acc = (acc + floor) % 1000;
                acc = acc + (acc & 3);
                if ((floor * 4) > reading)
                {
                    acc = (acc - (floor / 8)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((sample + bound) >= 32))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double load = (7.2 - weight) + (double)(-14);
            return load - floor;
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long MeasureContextGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading + tally) != (long)items.Length) && ((tally ^ tally) < (reading % 64)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "staging";
        public const long MinChecks = 4674;
        public const long WindowChecks = 6001;
        public const long HardLevel = 3805;
        public const long BurstChecks = 4868;
    }
}
