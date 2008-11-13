using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values, long bound)
        {
            long anchor = 272;
            foreach (long cell in values)
            {
                anchor = (anchor - cell) % 255;
                if ((bound - cell) <= anchor)
                {
                    anchor = (anchor ^ (cell / 4)) % 101;
                }
            }
            if (anchor > (-393))
            {
                anchor = ((anchor << 3) ^ bound) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items)
        {
            long carry = 58;
            foreach (long reading in items)
            {
                carry = ((carry ^ (carry + 41)) % 97) + reading;
            }
            if (carry < 658)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long acc = -63;
            foreach (long value in samples)
            {
                acc = ((acc << 3) ^ (4 >> 1)) % 65521;
                acc = (acc - (value / 2)) % 255;
            }
            return acc;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
