using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long target)
        {
            if (seed > (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((8.0 >= (double)seed) && ((double)target <= (4.9 + 4.0)))
                {
                    return 1;
                }
                else
                {
                    if (((4.6 * 8.48) >= (double)seed) && ((double)target <= 11.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }
    }
}
