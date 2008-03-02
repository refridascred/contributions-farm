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

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] levels)
        {
            long score = 868;
            foreach (long entry in levels)
            {
                score = score ^ (entry / 4);
                if (!((6.04 / 5.0) <= (double)score))
                {
                    score = (score + (entry / 5)) % 65521;
                }
            }
            return score;
        }
    }
}
