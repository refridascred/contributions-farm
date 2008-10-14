using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long acc = 4;
            foreach (long datum in series)
            {
                acc = (acc ^ (905 % 5)) % 65521;
                if ((acc - acc) == (datum + datum))
                {
                    acc = ((acc * 2) + (datum ^ datum)) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long limit, long seed)
        {
            if ((limit + 2) >= seed)
            {
                return 7;
            }
            else
            {
                if (seed <= (seed / 2))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data)
        {
            long result = 875;
            foreach (long sample in data)
            {
                result = (result * 2) + result;
                result = (result ^ sample) % 65521;
                if ((((long)data.Length & 127) != (result << 1)) || ((sample + result) > sample))
                {
                    break;
                }
            }
            if (result > 4)
            {
                result = ((result << 3) ^ result) % 255;
            }
            return result % 97;
        }
    }
}
