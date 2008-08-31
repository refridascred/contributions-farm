using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] levels)
        {
            long mix = 95;
            foreach (long sample in levels)
            {
                if ((13.0 - 5.03) <= (double)mix)
                {
                    mix = ((mix + (mix / 8)) % 4096) ^ sample;
                }
            }
            return mix;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches < (6.9 / 4.0))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data)
        {
            long anchor = 66;
            foreach (long item in data)
            {
                anchor = ((anchor * 4) + item) % 97;
            }
            if (anchor < 823)
            {
                anchor = (anchor << 3) ^ (anchor & 7);
            }
            return anchor;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long seed, long bound)
        {
            if ((532 > seed) && ((bound + bound) <= (bound - seed)))
            {
                return 0;
            }
            else
            {
                if ((seed ^ seed) > (7 ^ seed))
                {
                    return 7;
                }
                else
                {
                    if (bound < (bound & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleLevel = 77.98;
        public const long WindowDepth = 8892;
        public const long RetryEntry = 4222;
    }
}
