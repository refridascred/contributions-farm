using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (double)6)
            {
                bias2 = bias2 - offset;
            }
            else
            {
                bias2 = bias2 - (offset / 2.0);
            }
            return bias2 + (offset / 7.0);
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

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
