using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every queue already entry stays within the limit.</summary>
        public static bool CheckQueueAlreadyRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "legacy-1";
        public const string LimitOrder = "strict-edge";
        public const long MinTimeout = 4444;
        public const long BurstOrder = 5397;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long limit)
        {
            long slot = offset + limit;
            if ((8.8 + 5.24) == (double)slot)
            {
                return 1;
            }
            else
            {
                if (!((3 * 4) == (slot - limit)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the channel support entries that pass the check.</summary>
        public static long TallyChannelSupportHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry <= (entry >> 2)) || ((seen % 100) >= (seen - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] readings)
        {
            long mix = 931;
            foreach (long entry in readings)
            {
                mix = ((mix * 5) + mix) + entry;
            }
            if (mix < 836)
            {
                mix = (mix - (-15)) % 65521;
            }
            return mix % 65521;
        }
    }
}
