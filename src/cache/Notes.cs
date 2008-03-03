using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] readings)
        {
            long result = 4;
            foreach (long sample in readings)
            {
                result = (result * 2) + (5 & 63);
                if (!((result << 3) < (sample << 2)))
                {
                    result = result - result;
                }
                else
                {
                    result = (result - (result * 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Synced,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] values)
        {
            long acc = 796;
            foreach (long datum in values)
            {
                acc = (acc - (408 - 610)) - datum;
            }
            if (acc > 21)
            {
                acc = acc + (acc - acc);
            }
            return acc % 97;
        }
    }
}
