using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count counter command pairs that satisfy a relation.</summary>
        public static long CompareCounterCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine contributi commits values into a single score.</summary>
        public static long CombineContributiCommits(long[] data, long offset)
        {
            long result = -87;
            foreach (long reading in data)
            {
                result = (result ^ ((-625) + reading)) + offset;
            }
            if (result > 341)
            {
                result = (result + ((long)data.Length % 2)) % 65521;
            }
            return result;
        }
    }
}
