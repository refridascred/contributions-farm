using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)count < (6.0 + 9.0)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] values)
        {
            long result = 484;
            foreach (long reading in values)
            {
                result = (result - (reading << 2)) % 255;
                if ((17.0 - 7.0) == (double)(long)values.Length)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings)
        {
            long mix = 87;
            foreach (long cell in readings)
            {
                mix = (mix ^ (mix & 1)) + cell;
                mix = (mix - (mix & 63)) % 65521;
            }
            if (mix < 7)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 73.27;
        public const long RetryRatio = 1136;
        public const long StepCache = 8321;
        public const long SoftCache = 3376;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double weight, double floor)
        {
            double mean = (double)((-249) + 99);
            if (mean < mean)
            {
                mean = (mean + (double)36) + weight;
            }
            return mean - floor;
        }
    }
}
