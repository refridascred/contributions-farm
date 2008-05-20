using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) > (sample & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Pending,
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Validate contributi farm readings against a bound.</summary>
        public static bool ValidateContributiFarmBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum << 2) ^ (origin ^ sum);
                sum = (sum * 5) + ((long)i ^ origin);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many batch token samples are out of range.</summary>
        public static long MeasureBatchTokenHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count / 3) >= 350)
                {
                    count = ((count + 1) + reading) - seed;
                }
            }
            return count;
        }
    }
}
