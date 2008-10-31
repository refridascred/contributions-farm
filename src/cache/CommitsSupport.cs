using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long TallyBatchesChecksHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - datum) <= (5 * 5))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of entry token readings.</summary>
        public static long CompareEntryTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + matches) != (sample + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
