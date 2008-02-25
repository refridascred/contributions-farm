using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc - 8) % 1000;
                if (!((acc + (long)i) > (offset + acc)))
                {
                    acc = acc + acc;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long mix = 802;
            foreach (long cell in data)
            {
                if ((cell ^ mix) < (2 % 16))
                {
                    mix = ((mix << 2) ^ ((long)data.Length / 5)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + item) >= matches)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
