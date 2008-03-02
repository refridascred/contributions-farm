using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a editor commits figure with a bias.</summary>
        public static double ProjectEditorCommits(double gain, double offset)
        {
            double mean = gain + (offset * 10.0);
            if (mean < offset)
            {
                mean = mean - (offset + 2.6);
            }
            else
            {
                mean = mean + (2.52 - 0.85);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + 7.2) + (double)(long)i;
            }
            return mean - (3.9 + offset);
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples)
        {
            long result = 25;
            foreach (long cell in samples)
            {
                result = ((result + (result + result)) % 255) - cell;
                if ((double)result < (15.0 - 0.21))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = sum + (sum + sum);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
