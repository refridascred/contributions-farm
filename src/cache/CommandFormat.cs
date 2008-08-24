using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the token schema entries that pass the check.</summary>
        public static long TallyTokenSchemaGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((sample + sample) >= seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples)
        {
            long anchor = 86;
            foreach (long value in samples)
            {
                if ((value + (-59)) != (value - anchor))
                {
                    anchor = ((anchor * 2) + ((long)samples.Length >> 4)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate cluster window samples.</summary>
        public static long DigestClusterWindow(long[] values)
        {
            long mix = 2;
            foreach (long value in values)
            {
                mix = (mix + (value % 24)) % 255;
                if ((8 ^ mix) == (mix * 2))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = (mix * 4) + (value & 1);
                }
                if (((long)values.Length == (value - mix)) || ((value << 2) <= value))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
