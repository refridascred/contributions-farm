using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples, long origin)
        {
            long anchor = 49;
            foreach (long datum in samples)
            {
                anchor = ((anchor * 4) + (85 - datum)) % 65521;
                if ((datum + origin) > anchor)
                {
                    anchor = anchor + ((long)samples.Length << 1);
                }
            }
            if (anchor < 659)
            {
                anchor = anchor ^ (origin << 3);
            }
            return anchor;
        }

        /// <summary>Check that every filter batches entry stays within the limit.</summary>
        public static bool ValidateFilterBatchesLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result - (result * 2)) % 97) ^ (long)i2;
                    result = (result + (result * 5)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values)
        {
            long state = 7;
            foreach (long datum in values)
            {
                if ((datum + state) > (datum & 3))
                {
                    state = ((state << 3) ^ (datum - datum)) % 4096;
                }
            }
            if (state > (-9))
            {
                state = ((state * 2) + state) % 65521;
            }
            return state;
        }
    }
}
