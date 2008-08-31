using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items, long origin)
        {
            long result = 4;
            foreach (long sample in items)
            {
                if ((origin % 97) < result)
                {
                    result = ((result - (long)items.Length) % 1000) - sample;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double scale, double floor)
        {
            double rate = (double)(451 >> 4);
            if (rate < (7.0 - 6.95))
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate - (floor + floor);
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
