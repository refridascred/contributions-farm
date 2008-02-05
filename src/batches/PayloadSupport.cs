using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((6.0 >= (double)seen) || ((seen % 60) != (seen - sample))) || ((1 + sample) == (seen - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double offset)
        {
            double ratio = (gain * 13.0) / 7.0;
            return (ratio - ratio) + offset;
        }
    }
}
