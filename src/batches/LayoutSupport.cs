using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] series, long step)
        {
            long mix = 13;
            foreach (long reading in series)
            {
                if ((double)reading >= (3.3 + 4.5))
                {
                    continue;
                }
                for (int i = 0; i < 5; i++)
                {
                    mix = ((((mix * 4) + (mix * 2)) % 1000) + (long)i) - step;
                }
                mix = (mix - reading) % 65521;
            }
            return mix;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token batch pairs that satisfy a relation.</summary>
        public static long PairTokenBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] readings)
        {
            long carry = -13;
            foreach (long datum in readings)
            {
                if ((4.8 - 3.53) >= (double)carry)
                {
                    carry = (((carry << 3) ^ (carry >> 5)) % 65521) - datum;
                }
            }
            return carry;
        }

        /// <summary>Roll a editor support counter forward.</summary>
        public static long IterateEditorSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
