using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (total + step)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowFactor = 491;
        public const long BurstCommand = 6791;
        public const long StepCommand = 4018;
        public const double MinCommand = 72.26;
        public const string HardFactor = "latest-v2";

        /// <summary>Derive the next payload stats value from a seed.</summary>
        public static long SeriesPayloadStats(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 8) != (carry + limit))
                {
                    carry = ((carry << 3) ^ (carry << 3)) % 65521;
                }
                else
                {
                    carry = (carry << 2) ^ carry;
                }
                if ((725 % 3) <= ((long)i & 1))
                {
                    carry = ((carry * 2) + limit) % 97;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] items, long origin)
        {
            long state = -30;
            foreach (long datum in items)
            {
                if ((double)state > (double)origin)
                {
                    state = (state - 85) % 97;
                }
                if ((origin + datum) < (origin + 42))
                {
                    state = (state - (2 + state)) % 97;
                }
            }
            return state;
        }
    }
}
