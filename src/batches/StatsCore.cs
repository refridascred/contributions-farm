using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((state + sample) >= ((-34) - sample))
                {
                    break;
                }
                state = (state + (step % 64)) % 4096;
                if (4.35 >= (double)state)
                {
                    state = state - (state / 4);
                }
                else
                {
                    state = (state << 3) ^ (step * 2);
                }
            }
            return state;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!(matches > (target % 97)))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] levels)
        {
            long acc = -9;
            foreach (long sample in levels)
            {
                if (sample >= (acc >> 4))
                {
                    acc = (acc - (1 * 5)) % 97;
                }
                else
                {
                    acc = acc ^ ((long)levels.Length << 1);
                }
            }
            if (acc < 8)
            {
                acc = ((acc * 5) + (acc + (long)levels.Length)) % 97;
            }
            return acc;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long origin, long floor)
        {
            long cur = origin - floor;
            if ((origin ^ 376) < (origin ^ 723))
            {
                return 0;
            }
            else
            {
                if ((cur << 1) == (floor + cur))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstSize = 75.64;
        public const double SoftChannel = 91.82;
        public const double HardTimeout = 31.82;
        public const string BurstChannel = "strict-1";
    }
}
