using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit tools counter readings against a rule.</summary>
        public static long CountToolsCounterHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((7.73 < (18.0 + 18.0)) && ((reading - reading) < (matches << 1)))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Accumulate account contributi samples.</summary>
        public static long TallyAccountContributi(long[] values)
        {
            long state = 232;
            foreach (long reading in values)
            {
                if (((state & 63) >= (state + state)) || ((-39) >= (reading + reading)))
                {
                    state = state - (state + reading);
                }
                else
                {
                    state = ((state << 2) ^ reading) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of command cluster entries.</summary>
        public static long TallyCommandCluster(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                bool valid = (mix >> 3) > mix;
                if (valid || ((mix + reading) < (mix - mix)))
                {
                    mix = mix - (mix / 8);
                }
                mix = (mix + (reading * 2)) % 97;
            }
            if (mix > 28)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
