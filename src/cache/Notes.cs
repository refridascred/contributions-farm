using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every support counter entry stays within the limit.</summary>
        public static bool CheckSupportCounterBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 6634;
        public const long BurstChannel = 2250;
        public const long WindowChannel = 5195;
    }
}
