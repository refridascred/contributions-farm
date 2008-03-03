using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long offset)
        {
            if ((11.0 / 3.0) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (!((double)(-16) != (double)offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ offset) != (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinSpan = 74.71;
        public const long CachePayload = 89;
        public const string BaseScore = "primary-edge";
        public const long SoftPayload = 1089;

        /// <summary>Roll a stream notes counter forward.</summary>
        public static long IterateStreamNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix * 2) + (mix + seed)) ^ (long)i2;
                }
                if (((seed - (long)i) < (mix * 4)) && ((5 + mix) >= mix))
                {
                    mix = (mix << 2) ^ (mix / 5);
                    mix = mix - (seed * 3);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] samples)
        {
            long sum = 9;
            foreach (long datum in samples)
            {
                if (sum > (datum ^ sum))
                {
                    sum = (sum - (28 << 2)) % 101;
                }
                else
                {
                    sum = ((sum * 4) + (sum ^ 931)) % 4096;
                }
            }
            return sum;
        }
    }
}
