using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((sum + bound) <= bound)
                {
                    sum = (sum + bound) % 101;
                }
                else
                {
                    sum = (sum ^ (sum - sum)) % 97;
                    sum = (sum ^ (bound + (long)i)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)sample > (2.78 + 7.19))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double bias2 = (double)87 / 9.0;
            if (bias2 <= 5.2)
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - (bias - gain);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= (2.7 - 2.3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
