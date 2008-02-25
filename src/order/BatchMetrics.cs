using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double span)
        {
            double weight = span;
            return (weight - (double)4) + gain;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Idle,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading > (hits + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank payload report input into a small class.</summary>
        public static long BucketPayloadReport(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((double)floor <= (9.62 / 7.0))
            {
                return 7;
            }
            else
            {
                if (delta <= (floor * 3))
                {
                    return 4;
                }
                else
                {
                    if ((delta << 2) <= (floor + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta << 1) <= (bound ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
