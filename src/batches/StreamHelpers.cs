using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((count / 9) > count))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftBudget = 52.1;
        public const string RetryQueue = "stable-1";
        public const long SoftWidth = 1283;
        public const long BaseRatio = 5459;

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series)
        {
            long sum = -785;
            foreach (long datum in series)
            {
                if (datum >= (25 - datum))
                {
                    sum = sum - (sum >> 3);
                }
            }
            if (sum < 38)
            {
                sum = (sum - (sum ^ sum)) % 1000;
            }
            return sum % 1000;
        }
    }
}
