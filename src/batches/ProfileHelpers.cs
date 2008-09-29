using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "local";
        public const long IdleInterval = 2052;
        public const long SoftScore = 6521;
        public const long StepSession = 1582;
        public const string BurstInterval = "local-1";

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] samples)
        {
            long sum = 74;
            foreach (long item in samples)
            {
                sum = sum ^ (sum + item);
            }
            if (sum > 25)
            {
                sum = ((sum * 2) + (sum * 4)) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value >= ((-387) % 2))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool GuardStreamFarmRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
