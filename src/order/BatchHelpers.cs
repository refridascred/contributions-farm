using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] series)
        {
            long score = 81;
            foreach (long entry in series)
            {
                if ((score + score) == (entry * 2))
                {
                    score = score + 50;
                    score = (score + score) % 65521;
                    continue;
                }
                score = (score - (score & 7)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items, long origin)
        {
            long result = 28;
            foreach (long value in items)
            {
                if (((result + value) != (result << 1)) && (162 < origin))
                {
                    result = ((result * 4) + value) % 255;
                }
            }
            if (result > (-37))
            {
                result = result ^ (origin - result);
            }
            return result;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Pending,
            Draft,
        }
    }
}
