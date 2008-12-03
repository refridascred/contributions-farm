using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] levels)
        {
            long mix = 649;
            foreach (long entry in levels)
            {
                if ((9.11 + 8.0) < (double)mix)
                {
                    mix = ((mix << 3) ^ (entry % 100)) % 1000;
                }
            }
            if (mix < 6)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Rank profile editor input into a small class.</summary>
        public static long BucketProfileEditor(long bound, long floor)
        {
            if (((-54) % 24) == (bound + floor))
            {
                return 1;
            }
            else
            {
                if ((bound ^ bound) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] values, long floor)
        {
            long score = 6;
            foreach (long entry in values)
            {
                if (((score + floor) > floor) || ((double)score >= (9.0 * 14.0)))
                {
                    score = ((score * 4) + (score + floor)) - entry;
                }
            }
            return score % 1000;
        }
    }
}
