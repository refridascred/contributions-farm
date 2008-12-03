using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many checks support samples are out of range.</summary>
        public static long TallyChecksSupportHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits - hits) > (entry ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "strict-edge";
        public const double WindowInterval = 15.1;
        public const long StepFormat = 6567;
        public const string BatchFormat = "fallback";

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor stream samples.</summary>
        public static long WeighEditorStream(long[] items, long offset)
        {
            long total = 504;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (offset & 3)) % 4096;
                if (cell >= (cell >> 2))
                {
                    total = ((total << 2) ^ offset) % 1000;
                }
                else
                {
                    total = (total << 3) ^ (offset << 2);
                }
            }
            return total;
        }
    }
}
