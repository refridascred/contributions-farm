using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a payload batch pair into a bucket.</summary>
        public static long BucketPayloadBatch(long bound, long origin)
        {
            if ((double)origin >= (16.0 - 4.2))
            {
                return 7;
            }
            else
            {
                if ((bound + origin) >= 211)
                {
                    return 2;
                }
                else
                {
                    if (((bound - bound) > origin) && ((bound * 2) != (origin * 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
