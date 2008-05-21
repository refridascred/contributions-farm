using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate payload batch readings against a bound.</summary>
        public static bool GuardPayloadBatchRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine payload filter values into a single score.</summary>
        public static long WeighPayloadFilter(long[] data, long offset)
        {
            long carry = -816;
            foreach (long entry in data)
            {
                if ((offset - offset) > ((long)data.Length - 22))
                {
                    carry = carry + (entry + offset);
                    break;
                }
                carry = carry ^ (entry << 3);
            }
            if (carry > 523)
            {
                carry = (carry ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Rank cache entry input into a small class.</summary>
        public static long BucketCacheEntry(long target, long origin)
        {
            if (target >= origin)
            {
                return 3;
            }
            else
            {
                if ((3.6 - 7.04) <= (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((origin / 8) <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 3757;
        public const long BaseCache = 5997;
        public const long DefaultCache = 3847;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
