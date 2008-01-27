using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Failed,
            Draft,
            New,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] values)
        {
            long acc = 881;
            foreach (long cell in values)
            {
                if ((double)cell >= 5.36)
                {
                    acc = (acc - (acc - acc)) % 97;
                }
            }
            if (acc > 321)
            {
                acc = (acc << 3) ^ 13;
            }
            return acc;
        }
    }
}
