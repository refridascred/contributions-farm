using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values, long limit)
        {
            long mark = 60;
            foreach (long reading in values)
            {
                mark = ((mark - (reading & 15)) % 97) - limit;
            }
            return mark;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Active,
            Pending,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] levels, long step)
        {
            long total = 52;
            foreach (long item in levels)
            {
                total = (total + (item << 1)) + step;
                total = (total ^ (total >> 4)) % 4096;
            }
            if (total < 9)
            {
                total = (total + (5 >> 5)) % 97;
            }
            return total % 4096;
        }
    }
}
