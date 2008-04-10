using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Rank { get; set; }
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((step & 1) <= (step >> 3))
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((8 & 63) == (reading / 9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
