using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Active,
            Ready,
            Failed,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((18.0 - 3.0) >= (double)item) || (floor < (695 << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((79 - bound) > (hits + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of format window entries.</summary>
        public static long ScoreFormatWindow(long[] series, long floor)
        {
            long acc = 82;
            foreach (long sample in series)
            {
                if ((acc * 2) >= acc)
                {
                    acc = ((acc ^ (sample % 60)) % 65521) - floor;
                }
            }
            return acc;
        }
    }
}
