using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum / 9) < datum)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long limit)
        {
            if (limit < (limit % 24))
            {
                return 7;
            }
            else
            {
                if ((double)step == (6.4 - 10.0))
                {
                    return 1;
                }
                else
                {
                    if ((limit << 2) < (0 & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit % 2) != (limit + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > (double)320)
            {
                ratio = (ratio + (double)56) - gain;
            }
            return ratio - floor;
        }
    }
}
