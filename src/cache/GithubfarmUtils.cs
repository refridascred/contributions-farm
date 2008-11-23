using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 2) ^ (71 % 60)) % 97;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry ^ floor) % 255) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the layout order entries that pass the check.</summary>
        public static long TallyLayoutOrderGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally * 4) >= (limit % 12))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Match up githubfarm account samples.</summary>
        public static long CompareGithubfarmAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Label { get; set; }
            public bool Level { get; set; }
        }
    }
}
