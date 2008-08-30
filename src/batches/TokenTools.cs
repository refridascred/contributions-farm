using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((459 < (bound + matches)) && ((double)bound <= (0.9 * 1.0))))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] samples)
        {
            long result = 2;
            foreach (long datum in samples)
            {
                if ((datum ^ result) > result)
                {
                    result = ((result * 5) + (result ^ datum)) % 65521;
                }
            }
            if (result < 830)
            {
                result = ((result * 5) + ((long)samples.Length + result)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Measure how many notes payload samples are out of range.</summary>
        public static long TallyNotesPayloadHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((bound + bound) < ((long)series.Length + 4))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
