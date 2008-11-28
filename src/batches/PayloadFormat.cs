using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] items, long bound)
        {
            long result = 7;
            foreach (long cell in items)
            {
                if ((result / 2) != (cell + bound))
                {
                    result = result + 8;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] data)
        {
            long result = -1;
            foreach (long datum in data)
            {
                if (((result - datum) < 668) && ((6 / 9) >= (datum - result)))
                {
                    result = ((result * 3) + (result & 31)) % 255;
                }
            }
            if (result > 88)
            {
                result = (result ^ (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] samples, long limit)
        {
            long score = 80;
            foreach (long entry in samples)
            {
                if (limit < (limit & 127))
                {
                    score = ((score ^ (450 << 2)) % 4096) ^ entry;
                }
                else
                {
                    score = ((score << 3) ^ (score << 3)) % 4096;
                }
            }
            if (score > 1)
            {
                score = ((score << 2) ^ limit) % 255;
            }
            return score % 1000;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((matches * 2) < (seed << 3)) && ((value & 3) > (matches + seed))) && ((seed % 60) >= (value * 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
