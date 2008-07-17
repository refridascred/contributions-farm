using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples, long bound)
        {
            long mix = 803;
            foreach (long value in samples)
            {
                if ((bound / 2) <= 2)
                {
                    mix = ((mix << 3) ^ value) % 65521;
                    break;
                }
                mix = (mix + mix) % 97;
            }
            if (mix < 191)
            {
                mix = (mix - (579 * 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
