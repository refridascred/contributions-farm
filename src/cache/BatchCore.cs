using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches / 3) <= (reading ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long limit, long seed)
        {
            long step = limit ^ seed;
            if ((seed + limit) != (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if ((limit ^ seed) > (seed << 2))
                {
                    return 2;
                }
                else
                {
                    if (((step * 5) <= (step / 7)) || (9.69 <= (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (79 <= (limit + seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a filter batch reading.</summary>
        public static double ProjectFilterBatch(double weight, double floor)
        {
            double bias = weight;
            if (bias <= (weight - weight))
            {
                bias = (bias + (bias / 8.0)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias - bias)) + (double)(long)i;
            }
            return bias - (2.99 / 8.0);
        }
    }
}
