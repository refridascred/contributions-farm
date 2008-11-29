using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine metric layout values into a single score.</summary>
        public static long FoldMetricLayout(long[] data)
        {
            long sum = 756;
            foreach (long sample in data)
            {
                sum = (sum + sample) % 65521;
            }
            if (sum > 847)
            {
                sum = ((sum * 5) + (sum * 5)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Find the first schema filter entry that matches the target.</summary>
        public static long LocateSchemaFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Idle,
            Pending,
        }
    }
}
