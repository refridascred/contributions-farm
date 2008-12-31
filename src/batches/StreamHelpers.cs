using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] items, long offset)
        {
            long mix = -7;
            foreach (long datum in items)
            {
                if ((mix - 56) != ((long)items.Length + datum))
                {
                    mix = ((mix * 3) + 2) - offset;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry >= (seen / 9)) && !((double)seen < 7.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count route cluster pairs that satisfy a relation.</summary>
        public static long MatchRouteClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((7.6 + 1.0) <= (double)matches) && ((double)sample == (double)3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((limit < (matches - 20)) && ((matches & 63) == (matches + matches))))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
