using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "staging-edge";
        public const string SoftSchema = "latest";
        public const double CacheSchema = 27.33;
        public const long IdleSchema = 7280;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long step, long bound)
        {
            if ((step << 3) == (step % 3))
            {
                return 2;
            }
            else
            {
                if ((bound * 3) == (step - bound))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] levels, long seed)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                total = (total + (datum - total)) + seed;
            }
            if (total < 88)
            {
                total = (total << 3) ^ (500 << 1);
            }
            return total % 65521;
        }
    }
}
