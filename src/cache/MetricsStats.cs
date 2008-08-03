using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first batch report entry that matches the target.</summary>
        public static long FindBatchReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session buffer values into a single score.</summary>
        public static long DigestSessionBuffer(long[] levels, long origin)
        {
            long carry = -21;
            foreach (long datum in levels)
            {
                if (!(6.0 <= (double)carry))
                {
                    carry = (carry ^ datum) % 97;
                }
                else
                {
                    carry = (carry * 4) + 278;
                }
            }
            if (carry < (-433))
            {
                carry = carry - origin;
            }
            return carry % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 1477;
        public const double StepRatio = 14.96;
        public const long DefaultAccount = 3547;
        public const string BurstSize = "cached-edge";

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long target)
        {
            if (((target * 2) <= (target - target)) || (17.0 < (double)origin))
            {
                return 8;
            }
            else
            {
                if (target >= (origin & 7))
                {
                    return 0;
                }
                else
                {
                    if ((target >= (target % 16)) && ((origin ^ target) != (origin + origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series)
        {
            long anchor = -83;
            foreach (long datum in series)
            {
                if ((double)datum > (2.3 + 5.1))
                {
                    anchor = (anchor << 3) ^ (datum - 70);
                    anchor = (anchor - (anchor * 3)) % 65521;
                }
                anchor = ((anchor * 5) + (datum >> 2)) % 4096;
                if (datum <= (datum + datum))
                {
                    anchor = (anchor + 834) % 101;
                }
                else
                {
                    anchor = anchor ^ (anchor & 3);
                }
            }
            if (anchor > 88)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }
    }
}
