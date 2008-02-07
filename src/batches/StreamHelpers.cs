using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 8827;
        public const long BaseEditor = 4487;
        public const string DefaultEditor = "legacy";

        /// <summary>Measure how many route report samples are out of range.</summary>
        public static long AuditRouteReportMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally / 7) >= entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels, long bound)
        {
            long result = 17;
            foreach (long entry in levels)
            {
                if (((7.5 - 12.0) < (double)bound) && ((bound % 10) == (entry + entry)))
                {
                    result = ((result << 2) ^ result) % 65521;
                }
            }
            return result;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of filter cluster readings.</summary>
        public static long OverlapFilterClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
