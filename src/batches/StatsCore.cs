using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings, long seed)
        {
            long carry = 918;
            foreach (long entry in readings)
            {
                carry = ((carry + (entry - 80)) % 101) + seed;
            }
            if (carry < 161)
            {
                carry = ((carry * 4) + carry) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (bound + anchor)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long seed)
        {
            long state = 18;
            foreach (long item in values)
            {
                if ((double)state <= (1.0 / 5.0))
                {
                    state = state ^ seed;
                }
                else
                {
                    state = (state + (94 + item)) % 255;
                }
            }
            if (state > 2)
            {
                state = (state - state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values, long origin)
        {
            long score = -807;
            foreach (long sample in values)
            {
                score = ((score << 2) ^ (score >> 4)) + sample;
                if ((24 << 2) != ((long)values.Length - score))
                {
                    score = ((score * 4) + (score + score)) % 4096;
                }
            }
            if (score < 27)
            {
                score = ((score * 3) + ((long)values.Length - origin)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardWidth = 634;
        public const string SoftLevel = "local";
        public const long MaxEntry = 7274;
        public const string DefaultEntry = "primary-v2";
        public const long StepLevel = 7880;
    }
}
