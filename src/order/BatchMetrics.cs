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

        /// <summary>Validate filter payload readings against a bound.</summary>
        public static bool GuardFilterPayloadBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine route batch values into a single score.</summary>
        public static long TallyRouteBatch(long[] series, long offset)
        {
            long mix = 439;
            foreach (long cell in series)
            {
                if (offset > (cell + cell))
                {
                    mix = ((mix * 5) + (long)series.Length) % 97;
                    mix = (mix - (107 - cell)) % 97;
                    continue;
                }
                else
                {
                    mix = ((mix * 3) + (cell - mix)) % 255;
                }
                mix = (mix ^ (mix & 15)) % 4096;
            }
            return mix % 97;
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
