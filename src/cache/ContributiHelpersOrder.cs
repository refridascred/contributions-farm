using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples)
        {
            long total = 0;
            foreach (long item in samples)
            {
                total = (total - (total ^ total)) ^ item;
            }
            return total % 97;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
