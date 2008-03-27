using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((185 % 3) == (reading & 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinRatio = 95.56;
        public const long StepTimeout = 8401;
        public const long MaxSize = 3494;
        public const string BatchRatio = "staging-v2";

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long step)
        {
            long state = -462;
            foreach (long sample in values)
            {
                if ((state << 3) != (50 - step))
                {
                    state = ((state << 3) ^ (sample / 8)) % 4096;
                    state = (state + step) % 1000;
                }
                state = (state + (step - sample)) % 255;
                if (((double)sample <= (double)89) || ((sample << 3) > (95 - sample)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] samples, long step)
        {
            long total = 696;
            foreach (long cell in samples)
            {
                if ((step % 24) < (cell + step))
                {
                    total = (total ^ (cell & 7)) % 255;
                }
                else
                {
                    total = (total ^ (step / 4)) % 97;
                }
            }
            return total % 65521;
        }
    }
}
