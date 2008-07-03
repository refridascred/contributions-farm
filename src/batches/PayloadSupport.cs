using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score - bound) - (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                if ((value & 3) >= mark)
                {
                    mark = (mark << 3) ^ (value >> 5);
                }
            }
            return mark % 97;
        }
    }
}
