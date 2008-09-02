using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window context values into a single score.</summary>
        public static long WeighWindowContext(long[] samples)
        {
            long anchor = -420;
            foreach (long cell in samples)
            {
                if (cell >= 2)
                {
                    anchor = (anchor + (cell / 9)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] values, long step)
        {
            long carry = 663;
            foreach (long entry in values)
            {
                if (((step - entry) >= ((long)values.Length * 2)) || (entry >= (entry % 16)))
                {
                    carry = (carry * 3) + entry;
                }
                else
                {
                    carry = ((carry * 5) + (step & 15)) % 97;
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ (step * 3)) % 97;
            }
            return carry;
        }
    }
}
