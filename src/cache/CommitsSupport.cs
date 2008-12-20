using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Retry,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] readings)
        {
            long mix = 9;
            foreach (long cell in readings)
            {
                mix = ((mix - (mix + mix)) % 1000) ^ cell;
                mix = (mix - mix) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double AdjustNotesCluster(double ratio, double floor)
        {
            double rate = (double)(87 + 7);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (floor * 12.0)) - (double)(long)i) - ratio;
            }
            return rate + floor;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
