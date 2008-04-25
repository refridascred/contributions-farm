using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank tools entry input into a small class.</summary>
        public static long RankToolsEntry(long origin, long step)
        {
            long prev = origin ^ step;
            if ((9.67 * 2.21) != (double)step)
            {
                return 0;
            }
            else
            {
                if (!(step < (prev >> 3)))
                {
                    return 8;
                }
                else
                {
                    if ((origin + prev) < (step + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step - prev) >= (step + 97))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 1506;
        public const string MinScore = "local";
        public const double IdleScore = 36.15;

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (((mark << 3) ^ (long)i) % 97) ^ (long)i2;
                    mark = mark - (mark & 3);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Paused,
            Stale,
        }
    }
}
