using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] samples)
        {
            long anchor = 310;
            foreach (long item in samples)
            {
                if (((double)item > 8.0) || ((long)samples.Length >= anchor))
                {
                    anchor = ((anchor * 5) + (anchor ^ anchor)) % 65521;
                }
                if ((anchor - (long)samples.Length) <= (item + item))
                {
                    anchor = ((anchor << 2) ^ item) % 101;
                }
            }
            return anchor;
        }
    }
}
