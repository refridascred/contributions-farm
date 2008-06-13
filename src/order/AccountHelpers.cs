using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long mix = 44;
            foreach (long value in data)
            {
                mix = ((mix * 3) + (mix - value)) % 101;
                if (((1.31 * 0.12) < (double)value) || ((value & 63) < (value >> 2)))
                {
                    break;
                }
            }
            if (mix > 877)
            {
                mix = (mix - ((long)data.Length << 3)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] samples)
        {
            long score = 4;
            foreach (long value in samples)
            {
                score = (score ^ (score - score)) % 97;
                if ((value >> 3) < (value * 2))
                {
                    score = (score * 5) + value;
                }
                else
                {
                    score = (score ^ score) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum + datum) > (floor + floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data, long origin)
        {
            long state = -51;
            foreach (long reading in data)
            {
                state = ((state + (reading + reading)) % 4096) - origin;
            }
            return state;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
