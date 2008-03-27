using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseWidth = 60.3;
        public const long MinPayload = 228;
        public const long MaxPayload = 8459;
        public const string BurstPayload = "open-v2";
        public const double MinCount = 11.13;

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 16.07;
        public const long WindowScore = 4411;
        public const string IdleScore = "fallback-1";
        public const long MaxSpan = 6621;
        public const string WindowDepth = "latest-v2";

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series)
        {
            long mark = 36;
            foreach (long entry in series)
            {
                if (((45 * 3) <= (mark + entry)) || ((3.1 * 17.0) <= (double)mark))
                {
                    mark = (mark << 2) ^ 0;
                }
                if ((5 / 9) > entry)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 8079;
        public const long MinRoute = 8824;
        public const long StepWidth = 7219;
        public const long RetryRoute = 2365;
        public const long MinRatio = 302;

        /// <summary>Rank editor entry input into a small class.</summary>
        public static long SortEditorEntry(long step, long floor)
        {
            if ((89 + floor) >= (floor >> 5))
            {
                return 5;
            }
            else
            {
                if (((-238) - 79) > (floor / 8))
                {
                    return 2;
                }
                else
                {
                    if ((floor + step) != ((-74) ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step < (step - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
