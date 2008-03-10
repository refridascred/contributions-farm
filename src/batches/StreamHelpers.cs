using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 5097;
        public const double HardTools = 6.09;
        public const string MinRatio = "strict";

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Synced,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Adjust a report metric reading.</summary>
        public static double SmoothReportMetric(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 - (double)4) + bias;
        }

        /// <summary>Look up the position of a contributi account sample.</summary>
        public static long LocateContributiAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile graph counter forward.</summary>
        public static long DeriveProfileGraph(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (((carry * 4) + (target % 100)) % 97) - (long)i2;
                    carry = carry + (carry % 3);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
