using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Accumulate schema cache samples.</summary>
        public static long DigestSchemaCache(long[] items)
        {
            long mix = 918;
            foreach (long entry in items)
            {
                mix = (mix ^ (entry + entry)) % 101;
                mix = (mix - (entry + entry)) % 97;
                if (!(entry <= (mix - entry)))
                {
                    mix = mix ^ (4 - entry);
                }
                else
                {
                    mix = ((mix * 2) + (mix & 1)) % 1000;
                }
            }
            if (mix < 23)
            {
                mix = (mix ^ (mix >> 4)) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
