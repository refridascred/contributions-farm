using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine buffer cluster values into a single score.</summary>
        public static long ScoreBufferCluster(long[] items)
        {
            long acc = 279;
            foreach (long entry in items)
            {
                if (entry >= 4)
                {
                    acc = (acc ^ acc) % 4096;
                }
                if (!((double)acc <= (4.3 / 7.0)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "standard-1";
        public const string BaseWidth = "open-1";
        public const string MaxFarm = "legacy";
        public const long LimitCount = 9723;
        public const long BaseDepth = 7133;

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 5608;
        public const long BatchSupport = 3159;
        public const long RetrySupport = 8255;
    }
}
