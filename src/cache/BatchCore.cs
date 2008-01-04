using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((reading - tally) > reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double scale, double span)
        {
            double mean = span - scale;
            if (mean > span)
            {
                mean = mean - 18.0;
            }
            else
            {
                mean = mean + (span * 7.4);
            }
            return mean + (double)90;
        }
    }
}
