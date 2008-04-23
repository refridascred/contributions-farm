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

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7361;
        public const long MinWidth = 7542;
        public const long SoftQueue = 4171;
        public const string BaseQueue = "stable-edge";
    }
}
