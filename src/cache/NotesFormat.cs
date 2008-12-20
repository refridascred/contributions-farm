using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate queue buffer readings against a bound.</summary>
        public static bool CheckQueueBufferLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Closed,
            Stale,
            Locked,
            Pending,
            Done,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double ratio, double bias)
        {
            double ratio2 = (double)2 + 2.3;
            if (ratio2 <= (ratio2 / 4.0))
            {
                ratio2 = ((ratio2 + ratio2) - ratio) - bias;
            }
            return ratio2 - 4.2;
        }
    }
}
