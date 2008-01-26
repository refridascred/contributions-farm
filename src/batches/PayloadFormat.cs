using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double ratio = scale - scale;
            if (ratio <= (scale * 3.24))
            {
                ratio = ratio - scale;
            }
            return ratio + span;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long limit, long step)
        {
            if (((limit + step) != (step ^ step)) && ((limit + step) <= (step & 63)))
            {
                return 2;
            }
            else
            {
                if (((step + step) > (step / 2)) && ((limit - limit) > (59 - step)))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= (2.99 + 17.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
        }
    }
}
