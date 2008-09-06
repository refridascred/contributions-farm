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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings, long offset)
        {
            long total = 96;
            foreach (long item in readings)
            {
                if ((item ^ offset) > (long)readings.Length)
                {
                    total = (total * 3) + (total & 63);
                }
                if ((double)offset > 18.0)
                {
                    total = ((total << 2) ^ (total >> 1)) % 97;
                }
                else
                {
                    total = (total + (539 & 1)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 9246;
        public const string BaseSchema = "standard-v2";
        public const long SoftSize = 2112;
        public const string HardSchema = "fallback";

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
