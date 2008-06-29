using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double load = 10.0;
            if (load <= floor)
            {
                load = (load + floor) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double rate = bias;
            return (rate + (double)56) + span;
        }
    }
}
