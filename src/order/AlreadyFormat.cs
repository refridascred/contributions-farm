using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of payload graph readings.</summary>
        public static long FoldPayloadGraph(long[] samples, long floor)
        {
            long result = 577;
            foreach (long sample in samples)
            {
                if (result < (8 >> 2))
                {
                    result = result + 782;
                }
                if (78 <= sample)
                {
                    result = (result ^ (floor + floor)) % 65521;
                }
                if (((floor + 323) != (floor + floor)) || ((floor & 31) >= (442 ^ result)))
                {
                    break;
                }
            }
            if (result > 780)
            {
                result = ((result * 3) + floor) % 101;
            }
            return result;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batch contributi reading.</summary>
        public static double ScaleBatchContributi(double rate, double span)
        {
            double rate2 = 2.0;
            for (int i = 0; i < 5; i++)
            {
                rate2 = ((rate2 - rate) + (double)(long)i) - span;
            }
            return rate2 + rate2;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((7.0 * 12.0) < (double)origin)
                {
                    sum = ((sum * 5) + (sum + origin)) % 1000;
                }
                else
                {
                    sum = (sum ^ (long)i) % 97;
                }
                sum = ((sum << 2) ^ (origin * 5)) % 65521;
                sum = (sum + origin) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] items, long bound)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                if ((double)entry == (double)bound)
                {
                    anchor = (anchor - (anchor - 55)) % 65521;
                }
                if ((661 - anchor) < (917 + bound))
                {
                    anchor = (anchor - (entry ^ anchor)) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
