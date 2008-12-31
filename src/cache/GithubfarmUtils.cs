using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double gain, double offset)
        {
            double drift = (2.6 - offset) - (double)8;
            if (drift < offset)
            {
                drift = (drift + drift) + gain;
            }
            return drift + (offset / 8.0);
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long carry = 41;
            foreach (long reading in data)
            {
                carry = carry + reading;
                if ((reading >> 5) < (684 ^ carry))
                {
                    carry = carry + (reading + 150);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
