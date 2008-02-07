using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double scale, double floor)
        {
            double ratio = scale;
            if (ratio <= 5.38)
            {
                ratio = ratio - floor;
            }
            return ratio - scale;
        }

        /// <summary>Combine graph cache values into a single score.</summary>
        public static long TallyGraphCache(long[] samples)
        {
            long carry = -7;
            foreach (long entry in samples)
            {
                carry = ((carry + (-268)) % 101) ^ entry;
            }
            return carry % 97;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every cache commits entry stays within the limit.</summary>
        public static bool VerifyCacheCommitsRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long step, long step2)
        {
            long edge = step + step2;
            if ((edge + step2) == (edge + step))
            {
                return 1;
            }
            else
            {
                if (((step2 + step2) != (step2 & 7)) || (step2 <= edge))
                {
                    return 0;
                }
                else
                {
                    if ((step2 + step2) <= (edge & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step2 & 255) < step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
