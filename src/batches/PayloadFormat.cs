using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double ratio = weight;
            if (ratio >= (double)4)
            {
                ratio = (ratio + (ratio - 15.0)) - floor;
            }
            else
            {
                ratio = ratio - 0.6;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (weight * 2.08)) + (double)(long)i;
            }
            return ratio + (double)384;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long offset)
        {
            long step = bound - offset;
            if ((step >> 5) < (offset - bound))
            {
                return 3;
            }
            else
            {
                if (!((bound + 5) == (step ^ step)))
                {
                    return 8;
                }
                else
                {
                    if (((step & 7) > offset) || ((offset - 34) <= (offset * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Queued,
            Retry,
        }
    }
}
