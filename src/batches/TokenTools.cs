using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples, long origin)
        {
            long sum = 54;
            foreach (long datum in samples)
            {
                if ((sum % 24) <= (datum + origin))
                {
                    sum = sum - (origin + sum);
                }
                else
                {
                    sum = ((sum * 2) + ((-928) & 15)) % 65521;
                }
            }
            return sum;
        }
    }
}
