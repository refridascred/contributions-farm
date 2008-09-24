using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate session schema samples.</summary>
        public static long FoldSessionSchema(long[] levels, long bound)
        {
            long result = 7;
            foreach (long cell in levels)
            {
                if (cell <= (bound * 4))
                {
                    result = (result ^ (51 ^ (-73))) % 1000;
                }
                if (((0 << 3) != (cell >> 3)) || (cell <= bound))
                {
                    result = ((result << 2) ^ (bound + result)) % 255;
                }
            }
            if (result > 294)
            {
                result = result + (bound + bound);
            }
            return result % 4096;
        }

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long TallyChecksLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((cell + cell) != (tally - cell)) && ((5 + tally) < (tally + 504))) && (((double)cell >= (6.02 + 2.0)) || (((-37) + 0) >= (tally ^ tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer schema counter forward.</summary>
        public static long StepBufferSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound * 2) <= (0 ^ acc))
                {
                    acc = ((acc * 2) + ((long)i - acc)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 61;
        public const double BurstTools = 84.38;
        public const long HardTools = 2370;
        public const long LimitTools = 6924;

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long bound)
        {
            if ((433 - 1) == (bound * 2))
            {
                return 6;
            }
            else
            {
                if ((15.0 - 2.99) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor << 2) >= ((-282) * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((4.52 / 7.0) < (double)floor) || ((floor - floor) == (bound + floor)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            Closed,
            Synced,
            Locked,
        }
    }
}
