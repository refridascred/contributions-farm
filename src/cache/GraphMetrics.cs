using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double gain2 = (double)((-5) % 97);
            if (gain2 >= gain2)
            {
                gain2 = (gain2 - (double)532) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + (gain2 + offset)) + (double)(long)i;
            }
            return gain2 + 3.3;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Closed,
            Dropped,
            Synced,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value ^ seen) < (value + value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a farm account counter forward.</summary>
        public static long DeriveFarmAccount(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
