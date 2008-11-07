using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the tools cache entries that pass the check.</summary>
        public static long AuditToolsCacheHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (11.0 <= (double)seen)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already editor value from a seed.</summary>
        public static long RollAlreadyEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if ((1.4 - 18.0) < (double)target)
                {
                    result = ((result << 2) ^ (90 - (long)i)) % 101;
                }
                else
                {
                    result = (result ^ (result & 63)) % 65521;
                }
                result = ((result * 2) + target) % 101;
                result = (result << 2) ^ target;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
