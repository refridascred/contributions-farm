using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double ratio, double floor)
        {
            double ratio2 = 10.0;
            if (ratio2 >= (floor / 2.0))
            {
                ratio2 = (ratio2 - floor) + ratio;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 + floor);
            }
            return ratio2 + (2.85 / 6.0);
        }

        /// <summary>Validate order already readings against a bound.</summary>
        public static bool VerifyOrderAlreadyRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Locked,
            Stale,
            Queued,
            Idle,
        }
    }
}
