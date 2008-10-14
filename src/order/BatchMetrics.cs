using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state ^ seed) % 4096) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "local";
        public const long CacheSize = 8932;
        public const long HardInterval = 7355;
        public const long CacheQueue = 5032;
        public const double WindowQueue = 82.37;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count report checks pairs that satisfy a relation.</summary>
        public static long OverlapReportChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double load = bias;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (load - load)) + (double)(long)i) - floor;
            }
            return load + (2.54 - load);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data)
        {
            long sum = 32;
            foreach (long entry in data)
            {
                if (!((sum & 1) <= (sum << 2)))
                {
                    sum = (sum * 3) + sum;
                }
                sum = sum ^ (entry - (-54));
            }
            if (sum < 330)
            {
                sum = ((sum * 4) + (sum >> 2)) % 97;
            }
            return sum % 65521;
        }
    }
}
