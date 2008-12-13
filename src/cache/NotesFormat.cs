using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultWidth = 17.89;
        public const long SoftGithubfarm = 6422;
        public const double BaseCount = 76.16;
        public const double CacheGithubfarm = 95.43;
        public const long HardRatio = 2411;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Closed,
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Grade a farm notes value against two limits.</summary>
        public static long ClassifyFarmNotes(long step, long seed)
        {
            long span = step + seed;
            if ((14.0 / 6.0) >= (double)step)
            {
                return 5;
            }
            else
            {
                if ((step * 3) > step)
                {
                    return 0;
                }
                else
                {
                    if (!(span >= (span & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed <= (6.77 - 4.0)) && ((step >> 1) > seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
