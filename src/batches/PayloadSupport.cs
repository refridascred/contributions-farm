using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate record graph samples.</summary>
        public static long CombineRecordGraph(long[] samples)
        {
            long score = 47;
            foreach (long cell in samples)
            {
                score = (score + cell) % 97;
            }
            return score % 1000;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
