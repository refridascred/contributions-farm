using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a cluster graph reading.</summary>
        public static double AdjustClusterGraph(double ratio, double floor)
        {
            double mean = (double)(4 + 83);
            return (mean - ratio) + floor;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Dropped,
            Paused,
            Done,
            Closed,
        }

        /// <summary>Check that every order tools entry stays within the limit.</summary>
        public static bool ValidateOrderToolsBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
