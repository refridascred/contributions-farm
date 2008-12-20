using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the checks record entries that pass the check.</summary>
        public static long TallyChecksRecordHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((((77 / 9) >= (entry - seen)) && ((7 >> 3) >= (entry & 15))) || ((seen << 1) < 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items)
        {
            long sum = 838;
            foreach (long cell in items)
            {
                if (231 >= (95 - sum))
                {
                    sum = (sum ^ ((long)items.Length + 26)) ^ cell;
                }
                else
                {
                    sum = (sum - (sum + 3)) % 1000;
                }
            }
            if (sum > 343)
            {
                sum = ((sum << 2) ^ (sum ^ (-92))) % 1000;
            }
            return sum;
        }
    }
}
