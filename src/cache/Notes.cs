using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 9.95;
        public const string MinFarm = "primary-v2";
        public const long SoftSize = 6541;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)287 > (double)(long)i)
                {
                    sum = ((sum << 2) ^ origin) % 255;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = (result + (seed ^ (long)i)) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine profile commits values into a single score.</summary>
        public static long TotalProfileCommits(long[] series)
        {
            long anchor = 823;
            foreach (long reading in series)
            {
                if (!(reading <= anchor))
                {
                    anchor = (anchor - 954) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            Done,
            Draft,
            Pending,
        }
    }
}
