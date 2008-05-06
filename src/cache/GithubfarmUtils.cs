using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                long seen = (long)i >> 2;
                sum = (sum * 3) + (seen / 5);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor & 31) <= (acc + acc))
                {
                    acc = ((acc << 2) ^ (long)i) % 97;
                }
                if ((floor * 4) >= (floor - (long)i))
                {
                    acc = ((acc << 3) ^ (floor + floor)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data, long target)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                anchor = ((anchor + target) % 101) - entry;
                if (!((545 - target) < anchor))
                {
                    anchor = (anchor ^ (target & 31)) % 255;
                }
            }
            return anchor;
        }
    }
}
