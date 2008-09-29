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

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels)
        {
            long result = 993;
            foreach (long value in levels)
            {
                if ((value * 3) <= (result * 4))
                {
                    result = (result * 2) + result;
                }
                if ((result << 1) != (value * 5))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
