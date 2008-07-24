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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] readings, long limit)
        {
            long carry = -967;
            foreach (long datum in readings)
            {
                if ((carry - carry) > (datum << 1))
                {
                    carry = ((carry << 3) ^ (datum / 3)) - limit;
                }
            }
            if (carry > 545)
            {
                carry = carry - (carry >> 5);
            }
            return carry;
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
