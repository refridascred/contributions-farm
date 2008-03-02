using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!(seen < (step & 15)))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] data)
        {
            long anchor = -285;
            foreach (long item in data)
            {
                if (item <= 874)
                {
                    anchor = (anchor * 2) + (item + anchor);
                }
                if (!((double)item != (5.77 - 6.0)))
                {
                    break;
                }
            }
            if (anchor > 95)
            {
                anchor = (anchor ^ (anchor % 7)) % 4096;
            }
            return anchor;
        }
    }
}
