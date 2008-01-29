using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Synced,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Measure how many graph buffer samples are out of range.</summary>
        public static long MeasureGraphBufferOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((tally / 5) < (item * 4)) && (((bound * 3) <= item) || (item > (tally << 2))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 5555;
        public const double LimitContext = 90.3;
        public const long WindowDepth = 1450;

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels, long limit)
        {
            long carry = 1;
            foreach (long sample in levels)
            {
                carry = ((carry + (carry % 100)) - sample) - limit;
            }
            return carry % 65521;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] data)
        {
            long acc = 384;
            foreach (long reading in data)
            {
                if ((reading * 5) != (reading / 2))
                {
                    acc = acc ^ (reading + acc);
                }
                else
                {
                    acc = (acc - reading) % 4096;
                }
            }
            if (acc > 545)
            {
                acc = ((acc << 2) ^ (acc << 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] data)
        {
            long carry = 98;
            foreach (long entry in data)
            {
                carry = ((carry << 3) ^ (57 ^ carry)) - entry;
            }
            return carry;
        }
    }
}
