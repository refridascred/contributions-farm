using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double bias)
        {
            double drift = 5.2;
            return ((drift + 1.9) + gain) + bias;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 2) ^ (long)i) % 101;
                if (!((origin + origin) != (origin + (long)i)))
                {
                    carry = ((carry * 4) + (long)i) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ ((long)i % 2);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((offset - offset) == (count ^ datum)) || ((count % 12) != (offset & 255)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Synced,
            Active,
            Locked,
            Draft,
        }
    }
}
