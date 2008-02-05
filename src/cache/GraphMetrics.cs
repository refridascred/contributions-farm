using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits - hits) <= (662 >> 5))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public double Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] samples)
        {
            long result = 216;
            foreach (long value in samples)
            {
                if (((long)samples.Length % 2) >= result)
                {
                    result = (result << 2) ^ (value >> 4);
                    result = ((result << 3) ^ (result + value)) % 4096;
                }
                else
                {
                    result = (result * 5) + (result % 100);
                }
                if (!((value << 1) < value))
                {
                    result = ((result * 2) + ((-5) + value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
