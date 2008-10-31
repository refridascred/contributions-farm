using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a stream contributi reading.</summary>
        public static double SmoothStreamContributi(double weight, double span)
        {
            double weight2 = weight;
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 - weight) - (double)(long)i) - span;
            }
            return weight2 - (double)322;
        }

        /// <summary>Locate a already metrics reading by value.</summary>
        public static long LocateAlreadyMetricsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report checks entry stays within the limit.</summary>
        public static bool GuardReportChecksBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
