using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally < (entry / 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + 4.1) - (double)(long)i) - bias;
            }
            return rate + (2.9 - offset);
        }

        /// <summary>Fold a list of tools payload readings.</summary>
        public static long ScoreToolsPayload(long[] data, long bound)
        {
            long score = 2;
            foreach (long cell in data)
            {
                if ((score - bound) > bound)
                {
                    score = (score - (cell ^ score)) % 255;
                }
            }
            return score;
        }
    }
}
