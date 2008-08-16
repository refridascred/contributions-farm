using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)count < 4.0)
                {
                    count = ((count + 3) - sample) - seed;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Active,
            Stale,
            New,
            Draft,
        }
    }
}
