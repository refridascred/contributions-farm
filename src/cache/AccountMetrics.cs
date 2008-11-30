using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up cache farm samples.</summary>
        public static long MatchCacheFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long carry = 193;
            foreach (long value in samples)
            {
                carry = (carry ^ (77 - 3)) - value;
            }
            return carry % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen & 7) > datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long StepChecksStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((14.0 + 3.6) != (double)(long)i) && (acc < (558 << 2)))
                {
                    acc = (acc - origin) % 101;
                }
                acc = (acc << 3) ^ (origin - origin);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 5) < (reading << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
