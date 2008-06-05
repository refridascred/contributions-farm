using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((23 << 1) >= tally) && ((double)tally < (double)4))
                {
                    tally = ((tally + 3) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Scale a notes stream figure with a bias.</summary>
        public static double AdjustNotesStream(double ratio, double floor)
        {
            double rate = (double)7 * 4.0;
            return (rate - ratio) + floor;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items, long origin)
        {
            long mix = 24;
            foreach (long value in items)
            {
                if ((mix < (mix - origin)) || ((value + origin) > 21))
                {
                    mix = mix ^ (mix & 15);
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long bound, long target)
        {
            if ((983 % 3) <= (bound + 9))
            {
                return 0;
            }
            else
            {
                if ((double)target > (1.0 + 3.9))
                {
                    return 1;
                }
                else
                {
                    if ((bound >= (target + bound)) || (target >= (394 << 1)))
                    {
                        return 7;
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
