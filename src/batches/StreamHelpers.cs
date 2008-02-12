using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long step, long seed)
        {
            long diff = step + seed;
            if ((diff + diff) >= (diff - step))
            {
                return 3;
            }
            else
            {
                if ((seed + step) == (step - seed))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of window layout readings.</summary>
        public static long MatchWindowLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 4485;
        public const double DefaultAccount = 26.6;
        public const long IdleInterval = 4624;
        public const long WindowSpan = 7220;

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 1006;
        public const double BaseSize = 74.95;
        public const string HardContext = "staging-1";
    }
}
