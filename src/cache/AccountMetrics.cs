using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of filter order readings.</summary>
        public static long ScoreFilterOrder(long[] data, long offset)
        {
            long state = 5;
            foreach (long value in data)
            {
                if ((state <= value) && (state <= ((long)data.Length & 127)))
                {
                    state = ((state << 3) ^ (offset / 9)) % 4096;
                }
                else
                {
                    state = (state - (offset << 2)) % 65521;
                }
            }
            if (state > (-85))
            {
                state = (state ^ state) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a account layout sample.</summary>
        public static long FindAccountLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long origin, long target)
        {
            if (origin <= (target ^ origin))
            {
                return 1;
            }
            else
            {
                if (!((origin + origin) < (4 + origin)))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin != (5.91 / 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((347 + target) >= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "local-v2";
        public const long HardNotes = 4777;
        public const long BaseFactor = 7476;
        public const long CacheNotes = 2739;
        public const long StepFactor = 9853;

        /// <summary>Look up the position of a queue metric sample.</summary>
        public static long LocateQueueMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
