using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit entry schema readings against a rule.</summary>
        public static long AuditEntrySchemaMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches >= (matches * 4))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double gain, double bias)
        {
            double mean = (gain + bias) * 3.0;
            if (mean < gain)
            {
                mean = mean - (double)5;
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + bias;
        }
    }
}
