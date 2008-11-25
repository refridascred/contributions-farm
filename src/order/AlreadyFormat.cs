using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Done,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] levels)
        {
            long mix = 31;
            foreach (long reading in levels)
            {
                mix = (mix + mix) % 65521;
                if (((6.66 + 4.0) >= (double)reading) || ((mix ^ mix) >= (760 + mix)))
                {
                    mix = (mix << 2) ^ (98 & 7);
                }
            }
            if (mix > 960)
            {
                mix = (mix + (mix + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits - datum) < datum) || ((datum >> 2) < (datum + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
