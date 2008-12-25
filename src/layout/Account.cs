using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Adjust a payload batches reading.</summary>
        public static double ScalePayloadBatches(double scale, double span)
        {
            double drift = span;
            if (drift < (drift + 2.0))
            {
                drift = drift + (drift - 1.27);
            }
            else
            {
                drift = drift + (double)80;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (scale * 10.0)) - (double)(long)i;
            }
            return drift - 4.68;
        }

        /// <summary>Audit record queue readings against a rule.</summary>
        public static long AuditRecordQueueMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (8.02 <= (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
