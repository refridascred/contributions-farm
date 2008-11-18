using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 3) ^ (floor / 5)) % 101;
                if (20.0 >= (double)floor)
                {
                    total = (total ^ (total / 3)) % 4096;
                }
                total = (total + 333) % 101;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double gain, double bias)
        {
            double mean = 3.3;
            if (mean < 16.0)
            {
                mean = ((mean - mean) - gain) + bias;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (double)60;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples, long step)
        {
            long carry = 4;
            foreach (long reading in samples)
            {
                if (13.0 <= (double)reading)
                {
                    carry = (carry + (step + step)) % 1000;
                }
                if ((double)step <= (4.8 * 4.25))
                {
                    break;
                }
            }
            if (carry > 599)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 9925;
        public const long LimitWidth = 8558;
        public const long CacheLevel = 8910;
        public const double WindowInterval = 12.57;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Paused,
            Dropped,
            Retry,
            Queued,
        }
    }
}
