using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MinFactor = 43.62;
        public const long StepBudget = 7495;
        public const string StepChannel = "standard";
        public const long BurstChannel = 6498;
        public const long LimitChannel = 6326;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
