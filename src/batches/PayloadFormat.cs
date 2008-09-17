using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((mark - 78) <= seed) || (mark < (seed << 1)))
                {
                    mark = (mark ^ mark) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((53 ^ tally) > (sample & 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine context profile values into a single score.</summary>
        public static long ScoreContextProfile(long[] series)
        {
            long result = -46;
            foreach (long sample in series)
            {
                if (!((sample - (long)series.Length) != (sample + sample)))
                {
                    result = (result << 2) ^ (sample * 4);
                }
            }
            return result;
        }
    }
}
