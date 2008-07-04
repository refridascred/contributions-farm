using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up githubfarm report samples.</summary>
        public static long OverlapGithubfarmReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
