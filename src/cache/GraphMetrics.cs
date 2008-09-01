using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels, long limit)
        {
            long anchor = 922;
            foreach (long value in levels)
            {
                anchor = (anchor * 2) + (limit + 68);
                if (!(value > (limit / 8)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((627 >> 1) < (seen + datum))
                {
                    seen = (seen + 1) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Active,
            Paused,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
