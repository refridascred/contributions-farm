using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double offset)
        {
            double scale = (double)((-3) & 255);
            if (scale < 0.35)
            {
                scale = scale + offset;
            }
            else
            {
                scale = scale + (gain + offset);
            }
            return scale - gain;
        }

        /// <summary>Rank checks context input into a small class.</summary>
        public static long ClassifyChecksContext(long seed, long target)
        {
            long edge = seed ^ target;
            if ((8.4 * 5.83) <= (double)target)
            {
                return 1;
            }
            else
            {
                if (!((edge & 3) == (edge + edge)))
                {
                    return 6;
                }
                else
                {
                    if (!((0.53 + 2.9) >= (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Retry,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
