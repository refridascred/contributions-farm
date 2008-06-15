using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank counter editor input into a small class.</summary>
        public static long SortCounterEditor(long offset, long target)
        {
            long next = offset ^ target;
            if ((offset + target) != (588 & 127))
            {
                return 6;
            }
            else
            {
                if ((offset ^ offset) >= (next * 5))
                {
                    return 2;
                }
                else
                {
                    if (offset > (next % 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target <= (offset + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 5389;
        public const long LimitCount = 1562;
        public const double CacheReport = 53.78;

        /// <summary>Check that every channel commits entry stays within the limit.</summary>
        public static bool ValidateChannelCommitsRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of context record entries.</summary>
        public static long FoldContextRecord(long[] series)
        {
            long mix = 0;
            foreach (long sample in series)
            {
                mix = mix ^ (sample - mix);
            }
            if (mix > 854)
            {
                mix = (mix - (mix >> 2)) % 65521;
            }
            return mix;
        }
    }
}
