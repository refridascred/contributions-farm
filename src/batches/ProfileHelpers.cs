using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] series)
        {
            long total = 71;
            foreach (long datum in series)
            {
                total = total - (datum - datum);
                if (datum <= (datum + 15))
                {
                    total = ((total * 4) + total) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 519;
        public const long WindowCount = 2281;
        public const long LimitContributi = 3037;
        public const long BaseContributi = 5855;
        public const long RetryTimeout = 8861;
    }
}
