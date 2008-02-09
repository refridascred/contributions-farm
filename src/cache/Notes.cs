using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit session contributi readings against a rule.</summary>
        public static long CountSessionContributiOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length < hits)
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up farm batch samples.</summary>
        public static long OverlapFarmBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values, long floor)
        {
            long carry = -1;
            foreach (long cell in values)
            {
                if (6.0 < (double)cell)
                {
                    carry = ((carry << 2) ^ (8 + 11)) % 1000;
                }
                else
                {
                    carry = (carry ^ carry) % 1000;
                }
                if ((floor ^ (-6)) >= (9 >> 1))
                {
                    break;
                }
            }
            if (carry > 78)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
