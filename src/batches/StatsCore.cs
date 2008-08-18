using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of buffer stream readings.</summary>
        public static long TallyBufferStream(long[] values)
        {
            long mix = 8;
            foreach (long value in values)
            {
                if ((value + value) >= (mix << 2))
                {
                    mix = mix + (844 % 10);
                }
            }
            return mix;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 3) ^ (long)i) % 101;
                total = ((total << 3) ^ (long)i) % 97;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
