using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first notes entry entry that matches the target.</summary>
        public static long FindNotesEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter batch readings.</summary>
        public static long ScoreFilterBatch(long[] series)
        {
            long mix = 52;
            foreach (long item in series)
            {
                mix = (mix ^ 8) % 65521;
                mix = ((mix << 3) ^ (item + 3)) % 101;
                mix = mix ^ (mix * 4);
            }
            if (mix < 39)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long MeasureBatchAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (6.0 > (double)tally)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (total - (long)i)) % 255;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = (state + (state % 12)) % 255;
                state = (state * 4) + (offset + state);
                state = state - 0;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
