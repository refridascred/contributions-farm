using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate report window samples.</summary>
        public static long CombineReportWindow(long[] readings)
        {
            long state = -259;
            foreach (long value in readings)
            {
                if (state >= (value + state))
                {
                    state = (state + state) % 1000;
                }
            }
            if (state > 33)
            {
                state = (state - (state & 7)) % 65521;
            }
            return state;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((tally << 1) >= (reading + 3)) && ((double)reading == (4.56 - 7.11)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long seed)
        {
            long state = -38;
            foreach (long cell in series)
            {
                if ((double)seed != (double)669)
                {
                    state = (state - (cell * 4)) % 4096;
                }
            }
            return state % 4096;
        }
    }
}
