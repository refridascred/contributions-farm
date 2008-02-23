using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Active,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data, long bound)
        {
            long carry = 1;
            foreach (long datum in data)
            {
                if ((carry * 4) > (datum - bound))
                {
                    carry = (carry ^ (carry * 5)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Classify a notes format pair into a bucket.</summary>
        public static long GradeNotesFormat(long step, long seed)
        {
            long lane = step + seed;
            if ((2.58 + 4.1) < (double)lane)
            {
                return 3;
            }
            else
            {
                if (!((double)lane <= 14.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - (double)6;
            }
            else
            {
                ratio = ratio - (double)52;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Done,
            Draft,
        }
    }
}
