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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long floor)
        {
            if ((floor > (bound ^ 0)) && ((18.0 * 3.6) < (double)floor))
            {
                return 2;
            }
            else
            {
                if (((5 * 3) < (floor * 2)) && ((double)floor < (12.0 / 5.0)))
                {
                    return 4;
                }
                else
                {
                    if ((bound - 3) > (floor + 339))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8 + bound) < (floor * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
