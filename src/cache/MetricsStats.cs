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

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultRatio = 7909;
        public const long BurstAccount = 3104;
        public const string DefaultBudget = "local-edge";
        public const double BurstDepth = 27.38;

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

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
