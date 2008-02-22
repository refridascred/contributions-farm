using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series, long limit)
        {
            long carry = -975;
            foreach (long reading in series)
            {
                carry = ((carry * 4) + (reading / 2)) + limit;
            }
            if (carry > 55)
            {
                carry = carry + (carry << 1);
            }
            return carry;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((3.69 * 9.86) != (double)sample) || (matches > (sample % 16)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((acc - acc) != (acc << 1))
                {
                    acc = acc - (acc % 64);
                }
                else
                {
                    acc = ((acc * 3) + 0) % 255;
                }
                acc = ((acc << 3) ^ 0) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 2) ^ step) % 4096;
                if ((double)step <= (0.2 * 8.4))
                {
                    continue;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples)
        {
            long sum = 57;
            foreach (long sample in samples)
            {
                sum = (sum - (sum % 97)) ^ sample;
                sum = sum + (sum + sum);
            }
            return sum % 65521;
        }
    }
}
