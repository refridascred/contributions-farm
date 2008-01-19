using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every token profile entry stays within the limit.</summary>
        public static bool ValidateTokenProfileBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            New,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double bias, double span)
        {
            double gain = span;
            return (gain + span) + bias;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long seed)
        {
            long span = bound + seed;
            if (((seed % 97) > (span ^ seed)) || ((seed << 1) >= bound))
            {
                return 6;
            }
            else
            {
                if (((14.0 + 10.0) > (double)bound) || (span > (bound ^ span)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every order batches entry stays within the limit.</summary>
        public static bool GuardOrderBatchesRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
