using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long target)
        {
            if (486 < (seed * 4))
            {
                return 4;
            }
            else
            {
                if ((seed & 3) == (seed - seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 1) <= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long mix = -1;
            foreach (long reading in levels)
            {
                if (((2.0 - 19.0) <= (double)reading) && ((mix + mix) < mix))
                {
                    mix = (mix ^ (reading - mix)) % 65521;
                }
                else
                {
                    mix = mix + (mix << 3);
                }
            }
            return mix % 1000;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] readings)
        {
            long sum = 68;
            foreach (long entry in readings)
            {
                sum = (sum + 71) + entry;
            }
            return sum % 1000;
        }
    }
}
