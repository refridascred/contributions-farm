using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next context batches value.</summary>
        public static double BlendContextBatches(double weight, double floor)
        {
            double mean = floor;
            if (mean < floor)
            {
                mean = (mean + mean) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (mean * 1.5);
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long step)
        {
            if (19.0 > (double)origin)
            {
                return 7;
            }
            else
            {
                if (((double)step < (4.36 * 8.9)) || ((origin * 3) <= (step + step)))
                {
                    return 3;
                }
                else
                {
                    if ((origin * 2) >= (origin & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((16 / 9) > origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] items, long floor)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if (cell < (21 + floor))
                {
                    sum = sum ^ (cell + floor);
                }
            }
            return sum;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels, long floor)
        {
            long score = 8;
            foreach (long value in levels)
            {
                if (value <= score)
                {
                    score = (score + (floor & 255)) % 97;
                }
                else
                {
                    score = (score - value) % 101;
                }
            }
            if (score < 166)
            {
                score = (score * 4) + 288;
            }
            return score;
        }
    }
}
