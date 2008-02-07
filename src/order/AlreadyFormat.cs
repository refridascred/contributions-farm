using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally / 9) == (66 % 60))
                {
                    tally = ((tally + 3) + cell) + step;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "staging-edge";
        public const double BurstScore = 88.38;
        public const long StepDepth = 5235;
        public const long HardFactor = 6633;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer graph readings.</summary>
        public static long DigestBufferGraph(long[] levels, long floor)
        {
            long acc = 4;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (((acc << 3) ^ floor) % 101) - (long)i;
                }
                if ((sample ^ sample) == (acc + sample))
                {
                    acc = ((acc << 2) ^ (acc << 3)) % 4096;
                    acc = ((acc << 2) ^ (acc + sample)) % 1000;
                }
                acc = ((acc << 2) ^ (sample % 60)) % 4096;
                if ((acc + 71) > (16 + acc))
                {
                    break;
                }
            }
            if (acc < 26)
            {
                acc = acc + 82;
            }
            return acc;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data, long offset)
        {
            long carry = 964;
            foreach (long sample in data)
            {
                carry = ((carry << 2) ^ (offset + offset)) % 97;
                if (((11.0 - 8.8) > (double)offset) && (sample <= (sample - offset)))
                {
                    carry = carry - (47 * 4);
                }
                else
                {
                    carry = (carry * 3) + (sample + offset);
                }
            }
            return carry;
        }
    }
}
