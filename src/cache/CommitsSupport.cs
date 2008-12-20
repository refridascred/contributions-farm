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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) > (seen + 5))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double rate, double floor)
        {
            double mean = floor - rate;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean - rate)) + (double)(long)i;
            }
            return mean - floor;
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
