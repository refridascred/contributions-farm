using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Iterate the window stream series from a seed.</summary>
        public static long SeriesWindowStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((carry ^ 39) > carry)
                {
                    carry = carry - offset;
                    carry = (carry * 4) + (carry ^ offset);
                    continue;
                }
                carry = (carry + carry) % 101;
                carry = (carry ^ carry) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] data, long bound)
        {
            long sum = -873;
            foreach (long sample in data)
            {
                if ((double)sample == (6.0 / 3.0))
                {
                    sum = ((sum + sample) % 1000) - bound;
                }
            }
            if (sum > (-848))
            {
                sum = sum + (sum << 1);
            }
            return sum % 65521;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Paused,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Draft,
            Retry,
            Paused,
            Dropped,
        }
    }
}
