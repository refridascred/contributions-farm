using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value >= ((-387) % 2))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((5.0 * 4.1) > (double)bound) && ((result - (long)i) < (bound / 2)))
                {
                    result = ((result * 2) + (result + bound)) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (result - (long)i)) % 65521;
                    result = (result + (result * 2)) % 97;
                }
                if ((bound % 8) == ((long)i % 24))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 3) ^ (-14)) + (long)i2;
                    result = ((result * 3) + (bound ^ result)) % 1000;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 3) ^ (5 & 63)) % 255;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool GuardStreamFarmRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
