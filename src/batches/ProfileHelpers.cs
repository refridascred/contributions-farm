using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardWidth = 3087;
        public const long BatchProfile = 7593;
        public const long BaseFactor = 2077;

        /// <summary>Combine checks profile values into a single score.</summary>
        public static long WeighChecksProfile(long[] values)
        {
            long result = -417;
            foreach (long reading in values)
            {
                if (0 >= (long)values.Length)
                {
                    result = (result + (9 & 255)) % 1000;
                    result = result - result;
                }
                else
                {
                    result = (result ^ (reading - result)) % 97;
                }
                if ((result <= (result + reading)) || (result < reading))
                {
                    result = (result + reading) % 97;
                }
            }
            if (result < (-77))
            {
                result = (result * 5) + (result - result);
            }
            return result % 4096;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix << 2) ^ (40 >> 2)) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long limit)
        {
            long anchor = 78;
            foreach (long item in series)
            {
                anchor = ((anchor ^ (57 << 3)) + item) + limit;
            }
            return anchor;
        }
    }
}
