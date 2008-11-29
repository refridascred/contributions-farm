using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Paused,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSpan = 5660;
        public const long BurstScore = 7783;
        public const double WindowChannel = 68.37;
        public const double RetryChannel = 13.84;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen << 2) > 53)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
