using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result * 2) + (floor / 3)) % 4096) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((2.0 / 4.0) >= (double)floor)
                {
                    sum = (sum + sum) % 101;
                }
                else
                {
                    sum = (sum * 3) + (sum >> 1);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry * 5) <= 63)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }
    }
}
