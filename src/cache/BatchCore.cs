using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string WindowInterval = "primary";
        public const long MinFormat = 1961;
        public const long BurstFormat = 9064;
        public const long WindowFormat = 6461;
        public const long StepFormat = 4707;

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
