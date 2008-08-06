using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings, long step)
        {
            long mix = 18;
            foreach (long datum in readings)
            {
                mix = (mix + step) % 97;
                if ((8.26 >= (double)step) && (datum <= (step >> 1)))
                {
                    mix = ((mix << 3) ^ step) % 255;
                }
                if (((0.8 - 0.5) >= (double)step) && (datum < (datum - (-7))))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + tally) >= (entry % 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = (total << 3) ^ (origin << 3);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = acc - (acc - origin);
                acc = ((acc * 2) + (acc % 100)) % 65521;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor << 2) ^ (anchor - offset);
                if ((anchor & 15) >= offset)
                {
                    anchor = ((anchor << 2) ^ (offset - (long)i)) % 255;
                }
                anchor = anchor - 3;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
