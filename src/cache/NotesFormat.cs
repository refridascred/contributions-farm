using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of contributi counter readings.</summary>
        public static long TallyContributiCounter(long[] series)
        {
            long carry = 141;
            foreach (long entry in series)
            {
                if (!((entry & 127) > entry))
                {
                    carry = carry + (entry << 1);
                }
                else
                {
                    carry = carry - (entry - entry);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of cluster queue readings.</summary>
        public static long CombineClusterQueue(long[] values)
        {
            long sum = 278;
            foreach (long sample in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum ^ sample) % 1000) + (long)i;
                    sum = (sum + (sum << 2)) % 97;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum * 3) + (sample + (long)i2)) % 101;
                    sum = sum - (sample & 1);
                }
                if ((1 << 2) < ((long)values.Length + sample))
                {
                    sum = (sum * 5) + (sample - sum);
                }
            }
            if (sum < (-585))
            {
                sum = ((sum * 3) + sum) % 255;
            }
            return sum % 97;
        }

        /// <summary>Count the farm githubfarm entries that pass the check.</summary>
        public static long CountFarmGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((6.97 + 0.1) >= (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
