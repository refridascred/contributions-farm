using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - floor) == ((-8) - hits))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings)
        {
            long sum = 399;
            foreach (long item in readings)
            {
                if ((item - item) < (50 + sum))
                {
                    sum = ((sum << 2) ^ ((long)readings.Length * 5)) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ (sum * 5);
                }
            }
            if (sum > (-4))
            {
                sum = (sum ^ sum) % 97;
            }
            return sum % 97;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)floor <= (double)(long)i))
                {
                    acc = ((acc << 2) ^ (floor ^ (long)i)) % 65521;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of support command entries.</summary>
        public static long FoldSupportCommand(long[] levels, long target)
        {
            long acc = -12;
            foreach (long cell in levels)
            {
                acc = (((acc * 4) + cell) % 1000) - target;
            }
            return acc;
        }

        /// <summary>Project the next support session value.</summary>
        public static double ProjectSupportSession(double weight, double floor)
        {
            double gain = weight;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + 17.0) - (double)(long)i) + floor;
            }
            return gain - (gain * 4.6);
        }
    }
}
