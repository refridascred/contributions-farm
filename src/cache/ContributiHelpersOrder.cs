using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double weight, double span)
        {
            double gain = span / 5.0;
            if (gain >= (span * 2.9))
            {
                gain = gain + (weight * 6.0);
            }
            else
            {
                gain = gain + weight;
            }
            return gain - (weight + weight);
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Ready,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long target, long floor)
        {
            if ((double)2 != (double)target)
            {
                return 5;
            }
            else
            {
                if (target <= ((-191) + floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) <= (target << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((4.0 * 9.22) == (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
