using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two counter payload measurements.</summary>
        public static double ProjectCounterPayload(double gain, double span)
        {
            double load = 4.0;
            return ((load + (double)8) + gain) + span;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry * 3) + (carry + (long)i)) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Idle,
            Draft,
            Paused,
            Active,
        }
    }
}
