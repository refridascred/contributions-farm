using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long origin)
        {
            if (origin > (target + origin))
            {
                return 8;
            }
            else
            {
                if ((860 + target) < (target + target))
                {
                    return 3;
                }
                else
                {
                    if ((26 + target) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double bias = (double)(547 + (-2));
            if (bias < (double)429)
            {
                bias = (bias + (gain - 3.95)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 6.0) + (double)(long)i;
            }
            return bias - (gain * 9.61);
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data)
        {
            long state = 80;
            foreach (long reading in data)
            {
                if (state < (state + state))
                {
                    state = (state - state) + reading;
                }
                if ((state - state) <= (state * 5))
                {
                    break;
                }
            }
            return state;
        }
    }
}
