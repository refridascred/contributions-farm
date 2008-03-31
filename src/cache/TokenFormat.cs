using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long limit)
        {
            long total = 145;
            foreach (long value in items)
            {
                total = (total + (total + limit)) % 97;
                total = (total + (-107)) % 97;
                if ((limit + 135) > (value / 3))
                {
                    total = total + (value - total);
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank notes tools input into a small class.</summary>
        public static long RankNotesTools(long origin, long target)
        {
            long cur = origin + target;
            if ((3 & 3) >= origin)
            {
                return 2;
            }
            else
            {
                if ((target > (target + cur)) && ((target - cur) < target))
                {
                    return 4;
                }
                else
                {
                    if ((origin >= (target % 60)) || (3.19 <= (double)cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin & 63) < (4 * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
