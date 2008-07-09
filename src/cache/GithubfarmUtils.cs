using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Score { get; set; }
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long offset)
        {
            long sum = 0;
            foreach (long reading in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum - (offset - reading)) - (long)i;
                }
                sum = (sum ^ (reading - offset)) % 255;
            }
            if (sum > 5)
            {
                sum = ((sum << 3) ^ (offset - sum)) % 97;
            }
            return sum;
        }
    }
}
