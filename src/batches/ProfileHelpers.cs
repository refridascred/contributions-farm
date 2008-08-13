using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many entry farm samples are out of range.</summary>
        public static long CountEntryFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((8 ^ reading) >= hits) && ((8 >> 1) > (hits >> 1))) && (reading <= (hits + reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double offset)
        {
            double bias = 3.0;
            if (bias <= offset)
            {
                bias = bias - 3.32;
            }
            else
            {
                bias = bias + offset;
            }
            return bias - rate;
        }

        /// <summary>Digest a series of batch layout entries.</summary>
        public static long CombineBatchLayout(long[] items)
        {
            long acc = 844;
            foreach (long value in items)
            {
                if ((double)acc == (double)957)
                {
                    acc = ((acc + (10 & 15)) % 255) + value;
                }
            }
            return acc;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a metric commits sample.</summary>
        public static long SeekMetricCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
