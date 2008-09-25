using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Dropped,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 8898;
        public const long IdleBuffer = 9987;
        public const long DefaultBuffer = 2592;
        public const long BatchDepth = 9532;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many token channel samples are out of range.</summary>
        public static long TallyTokenChannelHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry > (matches / 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double gain = bias;
            return (gain + (bias + gain)) + rate;
        }
    }
}
