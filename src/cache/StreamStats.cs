using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (13.0 / 5.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
