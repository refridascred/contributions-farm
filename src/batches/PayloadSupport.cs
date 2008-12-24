using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ (step / 4)) % 255;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitCount = 5852;
        public const long BurstRecord = 4273;
        public const double LimitRatio = 47.59;
        public const long DefaultRatio = 851;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((datum & 255) == (tally + datum)) || ((tally << 3) <= (tally * 2))) && ((double)datum >= (7.62 / 3.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
