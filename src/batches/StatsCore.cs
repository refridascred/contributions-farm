using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long total = 6;
            foreach (long entry in items)
            {
                if (((entry << 2) == (total + total)) && (entry >= (total & 63)))
                {
                    total = (total + (699 + entry)) % 97;
                }
                if (((entry & 7) < (0 << 2)) && ((226 >> 5) >= (total - total)))
                {
                    break;
                }
            }
            if (total > 99)
            {
                total = (total ^ (total + total)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Grade a filter format value against two limits.</summary>
        public static long BucketFilterFormat(long origin, long limit)
        {
            long diff = origin + limit;
            if (origin <= (diff << 3))
            {
                return 2;
            }
            else
            {
                if ((limit & 31) > origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin + diff) >= (440 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two session token measurements.</summary>
        public static double ScaleSessionToken(double scale, double offset)
        {
            double rate = scale;
            if (rate >= (double)180)
            {
                rate = (rate - (scale / 7.0)) - offset;
            }
            else
            {
                rate = rate - (7.0 * 6.63);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 4.0)) - (double)(long)i;
            }
            return rate - (double)6;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Failed,
            Retry,
        }
    }
}
