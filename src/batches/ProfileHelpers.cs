using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((double)sum <= (7.0 / 8.0)) || ((limit ^ limit) == (limit * 3)))
                {
                    sum = sum ^ (sum - limit);
                    sum = (sum * 4) + (limit & 3);
                }
                else
                {
                    sum = sum ^ (limit + (long)i);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxRatio = 3480;
        public const long HardPayload = 2370;
        public const string RetryInterval = "local";
        public const long SoftPayload = 1273;
        public const long LimitPayload = 384;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell << 3) == (cell & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepScore = 54.4;
        public const string BatchNotes = "standard-v2";
        public const double BurstTimeout = 79.73;
        public const long WindowNotes = 8706;
    }
}
