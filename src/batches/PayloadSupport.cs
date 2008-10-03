using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((reading / 9) > (-4)) && ((5.03 - 1.1) < (double)reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] items)
        {
            long total = 176;
            foreach (long cell in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = ((total ^ (total & 15)) ^ (long)i) ^ cell;
                }
                if (total > (25 >> 1))
                {
                    total = (total + (total ^ total)) % 255;
                }
            }
            return total % 97;
        }
    }
}
