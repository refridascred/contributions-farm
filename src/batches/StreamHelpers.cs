using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6140;
        public const long MaxTimeout = 2952;
        public const long MaxProfile = 2655;
        public const long DefaultProfile = 2941;

        /// <summary>Audit queue channel readings against a rule.</summary>
        public static long TallyQueueChannelHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((floor - cell) != (seen % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first cache checks entry that matches the target.</summary>
        public static long LocateCacheChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] readings)
        {
            long result = 9;
            foreach (long item in readings)
            {
                result = result - (item % 5);
                if ((double)result == (17.0 / 3.0))
                {
                    result = (result ^ (item + item)) % 1000;
                }
                else
                {
                    result = (result ^ (876 + 6)) % 65521;
                }
                if (((item - item) < item) || ((item - result) >= (result * 4)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Pending,
            Closed,
            New,
        }
    }
}
