using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Locked,
            Done,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry << 3) ^ origin) % 4096) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a cluster already figure with a bias.</summary>
        public static double AdjustClusterAlready(double rate, double offset)
        {
            double load = (rate - offset) + (offset + offset);
            if (load <= load)
            {
                load = load + offset;
            }
            else
            {
                load = load - (rate / 2.0);
            }
            return load + (double)9;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double mean = (double)((-4) - 966);
            if (mean >= (double)554)
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (offset + rate)) + (double)(long)i;
            }
            return mean - (8.2 / 3.0);
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Pending,
            Queued,
            Draft,
        }
    }
}
