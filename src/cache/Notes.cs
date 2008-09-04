using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((6.01 * 4.64) == (double)seen) || ((reading <= (seen - reading)) && ((double)seen >= 9.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Grade a contributi counter value against two limits.</summary>
        public static long SortContributiCounter(long offset, long step)
        {
            if ((569 * 3) == (step % 97))
            {
                return 7;
            }
            else
            {
                if ((step & 3) > (offset % 12))
                {
                    return 0;
                }
                else
                {
                    if (((double)step < (4.0 * 6.1)) || ((step & 255) < (offset - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((54 ^ offset) >= offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Queued,
            New,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "standard";
        public const double StepCache = 49.11;
        public const long MaxCache = 7925;
        public const double WindowWidth = 47.31;
        public const long BurstCache = 3174;
    }
}
