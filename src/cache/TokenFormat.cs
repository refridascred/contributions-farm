using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 3) > (reading ^ reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Rank { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (step > (count / 8))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }
    }
}
