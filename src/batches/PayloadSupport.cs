using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double scale = (double)(43 ^ 81);
            if (scale > 12.0)
            {
                scale = ((scale - scale) + bias) + offset;
            }
            return scale - (scale * 2.25);
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Dropped,
            Done,
            Active,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
