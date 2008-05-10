using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long target)
        {
            if ((target - target) < (step + target))
            {
                return 5;
            }
            else
            {
                if ((target / 4) >= (807 & 255))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double bias, double floor)
        {
            double drift = floor;
            if (drift < (8.33 + bias))
            {
                drift = drift - 4.0;
            }
            else
            {
                drift = drift + bias;
            }
            return drift + floor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)target != (5.29 - 9.4))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long bound, long seed)
        {
            if (((20.0 / 5.0) <= (double)seed) || ((seed & 15) > (bound / 5)))
            {
                return 3;
            }
            else
            {
                if ((36 * 5) <= seed)
                {
                    return 0;
                }
                else
                {
                    if (((273 - bound) >= seed) || ((bound - 966) <= 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
