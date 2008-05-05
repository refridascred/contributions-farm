using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Ready,
            Retry,
            Draft,
            Idle,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings, long offset)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                if (((12.0 - 16.0) != (double)cell) || ((cell - offset) <= cell))
                {
                    total = total - offset;
                }
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (0 % 10)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Draft,
            Done,
            Failed,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
