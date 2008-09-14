using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                if ((14.0 - 2.7) == (double)total)
                {
                    total = (total ^ (total - (long)i)) % 4096;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry - (offset * 5)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the schema metric series from a seed.</summary>
        public static long DeriveSchemaMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Ready,
            Idle,
            New,
            Locked,
        }
    }
}
