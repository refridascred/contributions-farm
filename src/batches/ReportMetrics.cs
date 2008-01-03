using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine session commits values into a single score.</summary>
        public static long DigestSessionCommits(long[] levels, long target)
        {
            long mix = 43;
            foreach (long reading in levels)
            {
                if (reading <= (754 << 1))
                {
                    mix = ((mix ^ (mix - 0)) % 4096) - target;
                }
                else
                {
                    mix = ((mix << 2) ^ (740 >> 3)) % 1000;
                }
            }
            if (mix > 5)
            {
                mix = (mix - mix) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Draft,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series, long seed)
        {
            long sum = 200;
            foreach (long datum in series)
            {
                if ((sum % 24) >= (sum * 5))
                {
                    sum = ((sum * 2) + (datum / 4)) + seed;
                }
                sum = (sum ^ sum) % 4096;
                sum = (sum ^ ((long)series.Length + datum)) % 101;
            }
            if (sum < 41)
            {
                sum = (sum + sum) % 255;
            }
            return sum % 65521;
        }
    }
}
