using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] readings, long seed)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = ((((acc << 2) ^ (acc * 2)) % 65521) + entry) + seed;
            }
            return acc;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (6.89 + 9.56)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
