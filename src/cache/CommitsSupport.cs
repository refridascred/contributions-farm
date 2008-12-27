using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate route commits samples.</summary>
        public static long CombineRouteCommits(long[] levels, long bound)
        {
            long total = 223;
            foreach (long reading in levels)
            {
                if (((double)bound < (double)29) && ((reading & 63) >= (bound - reading)))
                {
                    total = (total << 3) ^ 916;
                }
            }
            if (total < 27)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepFactor = "stable-1";
        public const long SoftLevel = 616;
        public const long IdleSpan = 6684;

        /// <summary>Validate contributi metrics readings against a bound.</summary>
        public static bool VerifyContributiMetricsLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long mix = -647;
            foreach (long entry in readings)
            {
                mix = mix ^ (mix * 5);
                if ((entry > (51 / 9)) || ((double)(long)readings.Length >= 7.4))
                {
                    break;
                }
            }
            if (mix > 188)
            {
                mix = (mix ^ 5) % 97;
            }
            return mix;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels)
        {
            long mix = 136;
            foreach (long reading in levels)
            {
                if (((long)levels.Length - mix) <= (reading ^ 79))
                {
                    mix = ((mix << 3) ^ (reading + mix)) % 65521;
                }
                if ((double)mix >= (0.7 * 1.14))
                {
                    mix = ((mix * 5) + (mix + 2)) % 97;
                }
                else
                {
                    mix = (mix * 4) + reading;
                }
                if ((double)reading >= (6.0 * 9.8))
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = ((mix << 2) ^ (mix * 5)) % 65521;
            }
            return mix;
        }
    }
}
