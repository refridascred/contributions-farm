using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Classify a layout githubfarm pair into a bucket.</summary>
        public static long GradeLayoutGithubfarm(long seed, long target)
        {
            long step = seed ^ target;
            if ((step >= (target - (-589))) || (target >= (step * 4)))
            {
                return 3;
            }
            else
            {
                if (((seed - target) > seed) || ((step << 2) != (seed + target)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the format record series from a seed.</summary>
        public static long StepFormatRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                long delta = (target << 1) >> 5;
                if (339 > (long)i)
                {
                    carry = (carry + delta) % 65521;
                }
                else
                {
                    carry = (carry - ((long)i - delta)) % 101;
                    carry = (carry + (delta + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 3597;
        public const double CacheDepth = 38.26;
        public const double WindowCount = 37.2;
        public const long SoftFormat = 5463;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Queued,
            Ready,
            Paused,
            Stale,
            Synced,
        }
    }
}
