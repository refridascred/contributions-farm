using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every buffer schema entry stays within the limit.</summary>
        public static bool ValidateBufferSchemaRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of stream schema readings.</summary>
        public static long FoldStreamSchema(long[] readings, long floor)
        {
            long acc = -864;
            foreach (long cell in readings)
            {
                if (cell <= (267 >> 1))
                {
                    acc = (acc ^ (cell + floor)) % 97;
                }
                else
                {
                    acc = ((acc * 5) + (594 % 60)) % 101;
                }
                acc = (acc + acc) % 255;
            }
            if (acc > 5)
            {
                acc = acc + floor;
            }
            return acc % 1000;
        }

        /// <summary>Find the first checks token entry that matches the target.</summary>
        public static long LookupChecksTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
