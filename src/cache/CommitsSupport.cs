using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a entry contributi reading.</summary>
        public static double SmoothEntryContributi(double scale, double span)
        {
            double bias = (double)8 / 9.0;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (double)(long)i) - span;
            }
            return bias - (scale / 3.0);
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Pending,
            Done,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value >= (6.0 + 0.98))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples, long seed)
        {
            long carry = 134;
            foreach (long entry in samples)
            {
                carry = ((carry ^ (carry + entry)) % 4096) - seed;
            }
            if (carry < 981)
            {
                carry = (carry ^ (carry + carry)) % 101;
            }
            return carry % 65521;
        }
    }
}
