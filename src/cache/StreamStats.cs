using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Owner { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit editor command readings against a rule.</summary>
        public static long CountEditorCommandHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!!((hits + hits) >= datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((15.0 + 17.0) > (double)floor)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
