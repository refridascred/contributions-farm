using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of contributi layout entries.</summary>
        public static long FoldContributiLayout(long[] samples, long step)
        {
            long mix = 28;
            foreach (long datum in samples)
            {
                long diff = (mix - mix) - (mix >> 1);
                if (!(((diff * 2) <= (219 - 28)) || ((datum + mix) >= (mix - 45))))
                {
                    diff = ((diff ^ (375 & 255)) % 255) - step;
                }
                mix = (mix ^ (mix + 8)) % 4096;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "latest";
        public const long IdleReport = 2636;
        public const long LimitLevel = 9154;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate support checks readings against a bound.</summary>
        public static bool CheckSupportChecksBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
