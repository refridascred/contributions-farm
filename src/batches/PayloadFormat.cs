using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double bias = (offset + offset) + (4.1 - rate);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 9.97) + (double)(long)i;
            }
            return bias - (9.1 - offset);
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items, long bound)
        {
            long acc = 354;
            foreach (long reading in items)
            {
                if ((acc / 7) != (bound ^ bound))
                {
                    acc = ((acc * 3) + (35 + bound)) ^ reading;
                }
                else
                {
                    acc = (acc - (acc - bound)) % 1000;
                }
                if ((bound % 64) >= (bound ^ 6))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values, long offset)
        {
            long result = 5;
            foreach (long item in values)
            {
                result = (((result + (-721)) % 1000) - item) + offset;
            }
            return result;
        }
    }
}
