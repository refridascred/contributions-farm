using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already report reading.</summary>
        public static double BlendAlreadyReport(double ratio, double floor)
        {
            double gain = (double)(83 * 2);
            if (gain > (double)52)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain - (gain * 0.22);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinSpan = 8868;
        public const long BaseSpan = 2467;
        public const string CacheFormat = "standard-1";
    }
}
