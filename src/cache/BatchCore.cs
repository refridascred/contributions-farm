using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine command notes values into a single score.</summary>
        public static long TallyCommandNotes(long[] levels)
        {
            long result = 305;
            foreach (long reading in levels)
            {
                if (((reading >> 1) <= reading) && (reading < (reading + reading)))
                {
                    result = result + reading;
                }
            }
            if (result < 80)
            {
                result = (result + result) % 97;
            }
            return result % 65521;
        }

        /// <summary>Measure how many buffer layout samples are out of range.</summary>
        public static long TallyBufferLayoutGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >= (65 ^ limit)) || (((hits & 63) <= (hits % 97)) && ((double)limit > (1.35 * 11.0))))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate command token samples.</summary>
        public static long FoldCommandToken(long[] levels, long origin)
        {
            long score = 466;
            foreach (long item in levels)
            {
                if ((double)score < (9.9 * 1.9))
                {
                    score = ((((score * 2) + (score >> 5)) % 97) - item) + origin;
                }
            }
            return score;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long mix = 940;
            foreach (long datum in samples)
            {
                if (((-70) ^ datum) != ((-599) - datum))
                {
                    continue;
                }
                if ((mix / 9) > (mix - mix))
                {
                    mix = ((mix * 5) + datum) % 65521;
                }
                if ((datum + 53) > (mix + datum))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
