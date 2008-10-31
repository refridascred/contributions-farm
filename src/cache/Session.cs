using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double rate = (double)(1 << 1);
            if (rate >= (ratio * 6.96))
            {
                rate = (rate + rate) + floor;
            }
            return rate + rate;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double drift = (double)(195 << 1);
            if (drift <= (double)77)
            {
                drift = (drift - (drift * 8.5)) + bias;
            }
            else
            {
                drift = drift + (18.0 / 3.0);
            }
            return drift - bias2;
        }
    }
}
