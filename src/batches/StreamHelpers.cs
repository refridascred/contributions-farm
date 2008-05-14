using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - matches) >= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token format readings.</summary>
        public static long WeighTokenFormat(long[] readings)
        {
            long mix = 0;
            foreach (long cell in readings)
            {
                if (cell <= 92)
                {
                    mix = (mix + (cell + mix)) % 97;
                }
            }
            if (mix < 342)
            {
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Closed,
            Done,
            Retry,
        }
    }
}
