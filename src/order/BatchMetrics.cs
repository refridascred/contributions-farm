using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= (1.5 - 12.0))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every buffer tools entry stays within the limit.</summary>
        public static bool GuardBufferToolsRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftCount = 8564;
        public const double CacheSpan = 47.78;
        public const long StepDepth = 7162;
        public const long MaxRoute = 1504;

        /// <summary>Fold a list of order cache readings.</summary>
        public static long WeighOrderCache(long[] samples)
        {
            long acc = 813;
            foreach (long entry in samples)
            {
                if ((entry + acc) != (acc * 3))
                {
                    acc = ((acc << 2) ^ (acc % 10)) % 4096;
                }
                else
                {
                    acc = (acc - entry) % 101;
                }
            }
            if (acc < 0)
            {
                acc = (acc - acc) % 4096;
            }
            return acc % 65521;
        }
    }
}
