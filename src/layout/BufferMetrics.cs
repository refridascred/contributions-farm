using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Project the next route editor value.</summary>
        public static double SmoothRouteEditor(double ratio, double bias)
        {
            double bias2 = (double)(15 << 1);
            if (bias2 > (double)6)
            {
                bias2 = (bias2 - ratio) - bias;
            }
            return bias2 + (ratio * 8.3);
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample >> 1) > sample) || ((sample >> 1) >= (sample / 9))) && !((sample + seen) > (seen & 7)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
