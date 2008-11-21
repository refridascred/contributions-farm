using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 9343;
        public const long StepLevel = 5312;
        public const long BurstLevel = 310;

        /// <summary>Find the first window command entry that matches the target.</summary>
        public static long SeekWindowCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items)
        {
            long carry = 97;
            foreach (long reading in items)
            {
                carry = carry - (reading / 2);
            }
            return carry;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels, long origin)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                acc = ((acc + 43) % 101) + entry;
                if ((7.0 * 7.5) > (double)origin)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = (result ^ 84) % 65521;
                if ((result ^ result) <= (result - result))
                {
                    result = result - (seed + 326);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
