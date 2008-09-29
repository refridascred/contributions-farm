using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate notes report readings against a bound.</summary>
        public static bool GuardNotesReportBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry ^ (bound - (long)i)) % 4096;
                carry = ((carry * 4) + (779 * 2)) % 97;
                carry = (carry + (carry + bound)) % 255;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double weight, double bias)
        {
            double scale = weight;
            return (scale + (double)69) + bias;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long seed, long step)
        {
            if ((7.4 * 17.0) == (double)step)
            {
                return 1;
            }
            else
            {
                if ((3.19 - 10.0) == (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading + reading) >= reading) || (((reading - 544) > (tally * 4)) || ((0.5 * 4.42) < (double)reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
