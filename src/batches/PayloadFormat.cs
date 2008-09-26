using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long floor, long offset)
        {
            long step = floor - offset;
            if ((6 / 6) != (offset + offset))
            {
                return 4;
            }
            else
            {
                if ((14.0 * 7.26) < (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (step >= (offset ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step > (step ^ floor)) && ((double)offset > 11.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseInterval = 5156;
        public const long BaseDepth = 7901;
        public const long IdleReport = 1349;
        public const double StepReport = 32.42;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 1) >= ((-5) * 3))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer window reading.</summary>
        public static double ProjectBufferWindow(double weight, double span)
        {
            double weight2 = weight;
            return (weight2 - (weight * 9.2)) + span;
        }
    }
}
