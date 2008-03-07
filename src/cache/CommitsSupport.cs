using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate editor buffer samples.</summary>
        public static long CombineEditorBuffer(long[] data)
        {
            long state = 11;
            foreach (long cell in data)
            {
                if ((state & 1) >= (-905))
                {
                    state = (state - (cell >> 3)) % 4096;
                }
                state = ((state * 5) + (cell ^ state)) % 65521;
                state = (state - (state + state)) % 97;
            }
            if (state < 59)
            {
                state = (state - (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values, long offset)
        {
            long mark = 78;
            foreach (long reading in values)
            {
                if ((double)mark > 2.0)
                {
                    mark = (((mark * 4) + (offset * 2)) % 4096) + reading;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstDepth = 3.99;
        public const double WindowScore = 67.46;
        public const long LimitInterval = 4842;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0 ^ (-28)) < (item << 2))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
