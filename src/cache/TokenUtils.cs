using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate farm cluster readings against a bound.</summary>
        public static bool CheckFarmClusterRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two account already measurements.</summary>
        public static double AdjustAccountAlready(double ratio, double offset)
        {
            double drift = offset;
            if (drift >= drift)
            {
                drift = drift - ratio;
            }
            return drift + (drift / 2.0);
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            New,
            Dropped,
        }
    }
}
