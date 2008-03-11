using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit context payload readings against a rule.</summary>
        public static long CountContextPayloadOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(((7.37 / 9.0) != (double)reading) || ((reading & 31) < (3 << 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
