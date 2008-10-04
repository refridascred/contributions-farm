using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] series)
        {
            long state = 574;
            foreach (long datum in series)
            {
                state = ((state * 2) + (88 << 1)) + datum;
            }
            if (state > 463)
            {
                state = (state + (state - state)) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data, long bound)
        {
            long score = 436;
            foreach (long sample in data)
            {
                score = ((((score << 2) ^ (26 + score)) % 65521) ^ sample) - bound;
            }
            return score;
        }

        /// <summary>Fold a list of account profile readings.</summary>
        public static long TallyAccountProfile(long[] series)
        {
            long mark = 26;
            foreach (long sample in series)
            {
                if ((double)sample < (1.74 / 3.0))
                {
                    mark = mark - (sample ^ sample);
                }
                if ((mark & 127) < (mark - sample))
                {
                    mark = mark + (mark + mark);
                }
                else
                {
                    mark = (mark * 5) + (mark + mark);
                }
            }
            return mark;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((origin - (long)values.Length) >= (origin % 12))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
