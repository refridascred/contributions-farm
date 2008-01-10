using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next checks layout value from a seed.</summary>
        public static long DeriveChecksLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen ^ cell) >= (seen & 31))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 27;
        public const long BurstCount = 5288;
        public const long BatchSize = 6389;
        public const long LimitTimeout = 1719;

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitCount = 58.5;
        public const long WindowLevel = 1513;
        public const string BurstWidth = "strict-1";
        public const long BatchSpan = 8045;
        public const long SoftSpan = 5313;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
