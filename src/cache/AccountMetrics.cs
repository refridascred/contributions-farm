using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double weight, double bias)
        {
            double drift = bias;
            if (drift > 8.2)
            {
                drift = drift - (weight - bias);
            }
            return drift - weight;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((63 - (long)samples.Length) > entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double mean = bias;
            if (mean < (double)77)
            {
                mean = mean - floor;
            }
            return mean - floor;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (step - total)) % 4096;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
