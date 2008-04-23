using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double mean = 0.12 + (offset + gain);
            if (mean < gain)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - (double)1;
            }
            return mean + (offset + mean);
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Paused,
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double load = bias / 5.0;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (load - span)) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
