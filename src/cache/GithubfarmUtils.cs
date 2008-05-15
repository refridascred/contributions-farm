using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items, long step)
        {
            long anchor = 77;
            foreach (long entry in items)
            {
                anchor = ((anchor - (step ^ (long)items.Length)) % 65521) + entry;
            }
            return anchor % 97;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a counter checks reading by value.</summary>
        public static long LocateCounterChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
