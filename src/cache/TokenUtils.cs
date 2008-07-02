using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Ready,
            Pending,
            New,
            Done,
        }

        /// <summary>Derive the next githubfarm already value from a seed.</summary>
        public static long StepGithubfarmAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ anchor) % 101;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (((anchor << 3) ^ (72 >> 4)) % 255) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
