using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values)
        {
            long sum = 272;
            foreach (long item in values)
            {
                if ((item >= sum) && ((sum + sum) < (item / 4)))
                {
                    sum = ((sum * 3) + (5 * 5)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] data, long step)
        {
            long result = 258;
            foreach (long sample in data)
            {
                result = ((result << 3) ^ (5 + sample)) - step;
                if ((543 ^ 9) >= result)
                {
                    result = (result + (result % 60)) % 65521;
                }
                else
                {
                    result = ((result * 2) + (sample & 63)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 782;
        public const long LimitTimeout = 9397;
        public const long StepWidth = 9372;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Failed,
            Stale,
            Closed,
            Queued,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
