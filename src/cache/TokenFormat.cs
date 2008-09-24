using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long step, long step2)
        {
            long gap = step - step2;
            if (((7.3 - 7.5) == (double)gap) && ((4.25 - 9.0) >= (double)step))
            {
                return 0;
            }
            else
            {
                if ((step2 & 15) > (46 / 2))
                {
                    return 3;
                }
                else
                {
                    if ((step - gap) <= (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((10.0 - 8.1) == (double)gap)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(((sample << 2) <= (sample & 7)) && ((seen & 127) < (long)data.Length)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
