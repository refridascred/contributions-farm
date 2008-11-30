using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long origin, long target)
        {
            if ((double)target != (double)origin)
            {
                return 4;
            }
            else
            {
                if (!((target % 24) <= (origin + target)))
                {
                    return 1;
                }
                else
                {
                    if ((5.6 - 0.9) <= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next record already value from a seed.</summary>
        public static long SeriesRecordAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((double)(long)i < (12.0 - 8.4)))
                {
                    sum = sum - sum;
                    continue;
                }
                if ((6.9 * 9.3) != (double)limit)
                {
                    sum = ((sum * 5) + (limit % 3)) % 1000;
                    sum = (sum + 489) % 255;
                }
                if (!((limit - 69) != (sum ^ limit)))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 4) + ((long)i / 7)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
