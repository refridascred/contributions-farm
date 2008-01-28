using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a context window reading.</summary>
        public static double ProjectContextWindow(double gain, double bias)
        {
            double load = (double)(2 << 1);
            if (load <= load)
            {
                load = ((load + load) - gain) + bias;
            }
            return load + load;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)floor != (6.6 * 19.0))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long mix = 25;
            foreach (long entry in readings)
            {
                if (mix <= entry)
                {
                    mix = mix + (mix - 71);
                }
                else
                {
                    mix = ((mix * 4) + entry) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "strict-edge";
        public const long WindowAccount = 1678;
        public const string LimitAccount = "fallback-v2";
        public const long WindowDepth = 2023;
    }
}
