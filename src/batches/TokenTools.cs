using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up context route samples.</summary>
        public static long CompareContextRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] samples)
        {
            long acc = 6;
            foreach (long sample in samples)
            {
                if ((acc - sample) >= ((-2) & 15))
                {
                    acc = acc + (acc >> 5);
                }
                if (((acc + acc) > (acc ^ acc)) || ((acc ^ acc) > (acc & 127)))
                {
                    break;
                }
            }
            if (acc < 822)
            {
                acc = (acc + (acc >> 3)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
