using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = score - (score % 3);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = (result + result) % 255;
                result = ((result << 3) ^ (result >> 3)) % 4096;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((2.58 + 10.0) < (double)(long)readings.Length)
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
