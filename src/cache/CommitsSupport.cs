using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] values)
        {
            long carry = 18;
            foreach (long cell in values)
            {
                if ((cell % 2) > (cell & 1))
                {
                    carry = (carry - (cell << 2)) % 1000;
                    break;
                }
                carry = carry + (cell << 2);
            }
            return carry;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double bias, double bias2)
        {
            double gain = bias2;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)(long)i) - bias;
            }
            return gain - (9.22 * 5.8);
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
