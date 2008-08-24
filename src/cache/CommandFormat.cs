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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading >= (reading + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
