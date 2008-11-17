using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Active,
            Locked,
            New,
            Stale,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Retry,
            Stale,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) > datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next notes context value.</summary>
        public static double SmoothNotesContext(double bias, double span)
        {
            double load = span;
            return (load + (span + load)) + bias;
        }
    }
}
