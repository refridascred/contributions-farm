using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Draft,
            Ready,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = score + bound;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (((score << 2) ^ (bound / 6)) % 65521) + (long)i2;
                    score = (score ^ score) % 101;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels, long offset)
        {
            long result = 6;
            foreach (long item in levels)
            {
                result = ((result * 2) + (item + result)) % 255;
                if (((3 * 2) > (offset - item)) || ((8 + offset) == (result & 7)))
                {
                    break;
                }
            }
            if (result > 13)
            {
                result = (result << 2) ^ offset;
            }
            return result % 65521;
        }
    }
}
