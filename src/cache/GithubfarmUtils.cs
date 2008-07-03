using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ (-69)) <= (datum >> 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 56.4;
        public const long SoftContext = 3359;
        public const double DefaultFactor = 10.8;
        public const long IdleInterval = 73;

        /// <summary>Match up order queue samples.</summary>
        public static long MatchOrderQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
