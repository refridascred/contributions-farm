using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "local-edge";
        public const long RetryWidth = 9110;
        public const long WindowTimeout = 6130;
        public const long CacheFactor = 2369;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i <= (double)origin)
                {
                    state = state ^ (2 >> 4);
                    continue;
                }
                long prev = origin + (state & 31);
                state = (state * 2) + (prev + prev);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double scale, double offset)
        {
            double ratio = (double)(508 - 32);
            if (ratio >= (9.0 / 9.0))
            {
                ratio = ((ratio + (double)1) - scale) - offset;
            }
            return ratio + ratio;
        }
    }
}
