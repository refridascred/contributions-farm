using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] values)
        {
            long result = 1;
            foreach (long sample in values)
            {
                if ((58 % 10) > ((long)values.Length ^ result))
                {
                    result = ((result * 3) + sample) % 97;
                }
            }
            if (result > 54)
            {
                result = ((result * 5) + result) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
