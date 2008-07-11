using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank commits window input into a small class.</summary>
        public static long BucketCommitsWindow(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if ((next - next) != (278 >> 5))
            {
                return 5;
            }
            else
            {
                if ((next & 31) < (next + floor))
                {
                    return 2;
                }
                else
                {
                    if ((1.48 / 4.0) <= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Token { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a channel session reading by value.</summary>
        public static long SeekChannelSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
