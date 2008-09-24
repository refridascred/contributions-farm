using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 2264;
        public const long MinQueue = 2452;
        public const long HardQueue = 5732;
        public const long BurstQueue = 7619;
        public const double StepQueue = 27.15;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes commits pair into a bucket.</summary>
        public static long ClassifyNotesCommits(long target, long floor)
        {
            long offset = target + floor;
            if ((double)floor <= (double)target)
            {
                return 1;
            }
            else
            {
                if (((floor << 3) == (offset - offset)) && (offset < (target ^ floor)))
                {
                    return 6;
                }
                else
                {
                    if ((offset - offset) < floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
