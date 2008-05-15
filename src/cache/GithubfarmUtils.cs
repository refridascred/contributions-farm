using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i * 4) <= ((long)i % 10))
                {
                    acc = (acc * 4) + (origin + origin);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double offset)
        {
            double ratio = offset * 1.0;
            return (ratio - ratio) + gain;
        }
    }
}
