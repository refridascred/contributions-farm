using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm notes measurements.</summary>
        public static double AdjustGithubfarmNotes(double scale, double offset)
        {
            double weight = offset;
            if (weight <= (5.8 - scale))
            {
                weight = weight + (scale - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 9.64) + (double)(long)i;
            }
            return weight - (7.0 + offset);
        }

        /// <summary>Count the batches stats entries that pass the check.</summary>
        public static long MeasureBatchesStatsMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits < (17.0 / 8.0))
                {
                    hits = ((hits + 2) ^ cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
