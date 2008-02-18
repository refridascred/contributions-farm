using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            New,
            Draft,
            Dropped,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = 2;
            foreach (long value in samples)
            {
                total = total + (value + (-862));
            }
            if (total < (-55))
            {
                total = ((total << 2) ^ total) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftRatio = 8992;
        public const long BatchSize = 7098;
        public const long BurstCount = 3993;
        public const long WindowEditor = 788;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitCount = 3430;
        public const long SoftWidth = 9977;
        public const long DefaultLevel = 8754;
        public const long DefaultWidth = 2850;
        public const long DefaultBatches = 8044;
    }
}
