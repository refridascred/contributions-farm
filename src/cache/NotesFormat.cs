using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format queue values into a single score.</summary>
        public static long WeighFormatQueue(long[] data, long bound)
        {
            long sum = 0;
            foreach (long value in data)
            {
                sum = ((sum * 4) + bound) % 4096;
                if ((46 - (-9)) >= value)
                {
                    break;
                }
            }
            if (sum < 916)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a githubfarm checks reading.</summary>
        public static double ScaleGithubfarmChecks(double weight, double bias)
        {
            double mean = 5.9;
            if (mean >= bias)
            {
                mean = mean + weight;
            }
            return mean + (bias * 8.04);
        }
    }
}
