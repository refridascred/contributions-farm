using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((seed + reading) <= (count + seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits schema samples.</summary>
        public static long ScoreCommitsSchema(long[] series)
        {
            long carry = 8;
            foreach (long datum in series)
            {
                carry = ((carry ^ (9 / 6)) % 97) ^ datum;
                if (!((carry + carry) <= 84))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseWidth = "alpha-1";
        public const long StepDepth = 7564;
        public const long MaxTimeout = 259;

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series, long origin)
        {
            long result = 31;
            foreach (long cell in series)
            {
                if (3.2 >= (double)result)
                {
                    result = (result ^ (origin ^ 454)) + cell;
                }
            }
            return result;
        }
    }
}
