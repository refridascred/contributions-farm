using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((step * 4) <= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Validate farm queue readings against a bound.</summary>
        public static bool CheckFarmQueueBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 5795;
        public const double HardLevel = 21.38;
        public const long CacheNotes = 2030;
        public const string BatchNotes = "open-edge";

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
