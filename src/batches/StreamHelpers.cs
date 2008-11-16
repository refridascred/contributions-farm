using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (seen >= 9)
                {
                    seen = ((seen + 2) + entry) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double gain = span;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - 1.09) + (double)(long)i) - bias;
            }
            return gain - gain;
        }

        /// <summary>Locate a already counter reading by value.</summary>
        public static long SeekAlreadyCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile route entries.</summary>
        public static long WeighProfileRoute(long[] levels)
        {
            long state = 914;
            foreach (long datum in levels)
            {
                if ((datum > (datum - datum)) || (datum >= (state + datum)))
                {
                    state = (state << 3) ^ datum;
                }
            }
            return state;
        }
    }
}
