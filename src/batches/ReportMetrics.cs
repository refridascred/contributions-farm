using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] series)
        {
            long anchor = 461;
            foreach (long reading in series)
            {
                if ((reading - anchor) > 88)
                {
                    anchor = (anchor - (anchor - reading)) % 101;
                }
            }
            return anchor;
        }
    }
}
