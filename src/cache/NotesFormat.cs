using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
