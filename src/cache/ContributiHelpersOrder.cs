using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            Closed,
            Stale,
            Paused,
            Active,
        }

        /// <summary>Check that every payload record entry stays within the limit.</summary>
        public static bool CheckPayloadRecordLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 > (rate2 + rate2))
            {
                rate2 = (rate2 + offset) - rate;
            }
            return rate2 - (offset * 7.4);
        }
    }
}
