using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long limit)
        {
            long slot = offset + limit;
            if ((limit + 409) >= slot)
            {
                return 6;
            }
            else
            {
                if (!((offset ^ offset) <= (slot + 325)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of layout editor readings.</summary>
        public static long TallyLayoutEditor(long[] values)
        {
            long sum = 29;
            foreach (long reading in values)
            {
                if ((9.19 + 5.27) != (double)reading)
                {
                    sum = sum ^ (sum * 5);
                }
                else
                {
                    sum = ((sum * 5) + (sum & 127)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of account support readings.</summary>
        public static long MatchAccountSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
