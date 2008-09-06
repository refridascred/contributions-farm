using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = (total << 3) ^ (total ^ target);
                total = (total * 4) + (target % 10);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long limit)
        {
            if ((double)target > (8.59 / 6.0))
            {
                return 2;
            }
            else
            {
                if (!((target + target) >= (limit + limit)))
                {
                    return 4;
                }
                else
                {
                    if (((limit % 8) == (target & 3)) || ((limit % 64) < target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target ^ (-98)) <= (-79))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window farm readings.</summary>
        public static long WeighWindowFarm(long[] samples, long seed)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                sum = ((sum * 3) + (sum % 60)) ^ entry;
            }
            if (sum < 230)
            {
                sum = sum ^ (seed + sum);
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
