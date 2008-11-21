using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long offset)
        {
            if (((3.3 / 8.0) == (double)offset) && ((origin % 100) > (offset + origin)))
            {
                return 2;
            }
            else
            {
                if (!((offset % 12) <= (offset / 3)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a farm stats reading by value.</summary>
        public static long SeekFarmStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series, long origin)
        {
            long state = 84;
            foreach (long item in series)
            {
                if ((origin * 4) < origin)
                {
                    state = (state ^ (51 - item)) % 1000;
                }
            }
            return state % 1000;
        }
    }
}
