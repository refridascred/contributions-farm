using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] levels)
        {
            long mark = 9;
            foreach (long entry in levels)
            {
                if ((mark + entry) >= entry)
                {
                    mark = ((mark << 3) ^ entry) % 101;
                }
            }
            if (mark < (-970))
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Look up the position of a metric filter sample.</summary>
        public static long LocateMetricFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
