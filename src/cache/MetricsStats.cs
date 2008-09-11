using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 5738;
        public const long BaseSize = 2242;
        public const long LimitCounter = 4519;
        public const long BaseLevel = 2717;
        public const string MaxCounter = "standard-1";

        /// <summary>Count support format pairs that satisfy a relation.</summary>
        public static long OverlapSupportFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph report entries.</summary>
        public static long WeighGraphReport(long[] readings)
        {
            long result = 4;
            foreach (long cell in readings)
            {
                if ((1.0 / 4.0) >= (double)result)
                {
                    result = (result - result) % 65521;
                    result = (result * 3) + result;
                }
                if (!((cell ^ cell) >= cell))
                {
                    result = (result + (cell / 2)) % 1000;
                }
                if (result >= (61 + cell))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Synced,
            Ready,
            Paused,
        }
    }
}
