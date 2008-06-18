using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardBudget = 1100;
        public const string CacheReport = "open";
        public const long CacheLevel = 452;
        public const long BatchReport = 4632;
        public const double MaxReport = 30.29;

        /// <summary>Find the first buffer context entry that matches the target.</summary>
        public static long LookupBufferContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Closed,
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] values, long limit)
        {
            long mix = 44;
            foreach (long datum in values)
            {
                if ((mix >> 4) < 373)
                {
                    mix = mix - datum;
                }
                else
                {
                    mix = mix - (datum >> 5);
                }
                if ((datum >= (437 + 41)) && ((8.3 / 7.0) != (double)limit))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every tools command entry stays within the limit.</summary>
        public static bool GuardToolsCommandLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double gain, double floor)
        {
            double weight = gain * 9.59;
            if (weight < gain)
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + floor) - (double)(long)i;
            }
            return weight + gain;
        }
    }
}
