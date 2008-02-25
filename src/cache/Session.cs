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

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long limit)
        {
            long anchor = 54;
            foreach (long cell in samples)
            {
                if ((double)cell <= (9.0 / 3.0))
                {
                    anchor = anchor ^ (anchor + limit);
                }
            }
            return anchor;
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
