using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinBudget = 7156;
        public const long BurstAlready = 3528;
        public const double DefaultLevel = 87.4;

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = (score << 2) ^ (score << 2);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
