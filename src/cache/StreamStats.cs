using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series)
        {
            long carry = 8;
            foreach (long datum in series)
            {
                if (((carry * 2) != (carry + datum)) && ((carry << 2) < (datum << 3)))
                {
                    carry = ((carry * 4) + (datum + carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - matches) < datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already filter entries.</summary>
        public static long WeighAlreadyFilter(long[] samples, long bound)
        {
            long result = 46;
            foreach (long cell in samples)
            {
                if ((bound / 9) <= result)
                {
                    result = (result - (4 + 8)) + cell;
                }
            }
            return result % 97;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ (score >> 2);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
