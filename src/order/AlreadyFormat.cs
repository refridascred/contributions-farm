using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] readings, long floor)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                mark = ((mark * 3) + floor) % 65521;
                mark = (mark * 5) + (cell << 2);
                mark = ((mark * 2) + (cell - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Locked,
            Pending,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Dropped,
            New,
            Active,
        }
    }
}
