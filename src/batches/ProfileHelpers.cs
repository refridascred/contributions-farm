using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseBudget = 404;
        public const string RetrySize = "open-edge";
        public const long DefaultSupport = 2210;
        public const double BatchSupport = 84.5;

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph context series from a seed.</summary>
        public static long SeriesGraphContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((2.48 / 7.0) != (double)score)
                {
                    score = (score ^ floor) % 255;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score ^ floor) ^ (long)i2;
                    score = (score ^ floor) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Locked,
            Pending,
        }
    }
}
