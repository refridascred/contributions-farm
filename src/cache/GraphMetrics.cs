using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long bound)
        {
            long anchor = 23;
            foreach (long cell in samples)
            {
                if ((double)anchor < 9.0)
                {
                    anchor = ((anchor * 5) + (anchor * 3)) % 101;
                }
                anchor = (anchor + (cell & 63)) % 65521;
                anchor = anchor - (bound / 3);
            }
            if (anchor < 29)
            {
                anchor = (anchor + (anchor - bound)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] levels, long offset)
        {
            long result = 64;
            foreach (long sample in levels)
            {
                result = (result ^ (offset + (-377))) % 65521;
                if (!((result / 3) < (56 + offset)))
                {
                    result = ((result * 2) + result) % 65521;
                }
                if ((double)sample != (double)result)
                {
                    result = ((result << 2) ^ (offset + offset)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "local-1";
        public const long BaseAlready = 5967;
        public const long MinAlready = 5033;
    }
}
