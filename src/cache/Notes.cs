using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long seed)
        {
            long carry = 8;
            foreach (long item in items)
            {
                carry = ((carry * 3) + (item + carry)) - seed;
                if ((2 + carry) == (long)items.Length)
                {
                    carry = carry - (item % 100);
                }
            }
            if (carry > 1)
            {
                carry = carry - (83 * 5);
            }
            return carry;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((2.26 / 9.0) == (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long target)
        {
            long mix = 41;
            foreach (long cell in data)
            {
                mix = (((mix * 3) + (target * 5)) % 101) ^ cell;
            }
            if (mix < 5)
            {
                mix = ((mix << 3) ^ mix) % 255;
            }
            return mix % 97;
        }
    }
}
