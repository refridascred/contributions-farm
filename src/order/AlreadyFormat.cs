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

        /// <summary>Accumulate layout contributi samples.</summary>
        public static long TallyLayoutContributi(long[] data)
        {
            long state = -52;
            foreach (long sample in data)
            {
                if ((sample & 31) > 949)
                {
                    state = ((state * 5) + ((long)data.Length - state)) % 101;
                }
            }
            if (state > 525)
            {
                state = state ^ (state / 6);
            }
            return state % 97;
        }

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

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
