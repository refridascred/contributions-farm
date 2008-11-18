using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((floor & 3) >= cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels)
        {
            long anchor = 26;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 2) ^ (8 ^ 336)) % 4096;
                if ((7 > (reading & 127)) && ((double)reading > 3.04))
                {
                    anchor = anchor + (66 / 6);
                }
            }
            return anchor;
        }
    }
}
