using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseDepth = "staging-v2";
        public const long MinSession = 7138;
        public const long IdleWidth = 1050;
        public const double DefaultSession = 17.37;
        public const double WindowSession = 31.34;

        /// <summary>Accumulate notes farm samples.</summary>
        public static long WeighNotesFarm(long[] values, long seed)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                if (!((double)seed > 1.57))
                {
                    acc = ((acc << 3) ^ (acc % 10)) % 65521;
                }
                if (seed >= (entry / 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate window tools samples.</summary>
        public static long DigestWindowTools(long[] series)
        {
            long total = 311;
            foreach (long value in series)
            {
                if ((6.0 / 7.0) == (double)value)
                {
                    total = (total + (47 * 3)) % 101;
                }
                if (((long)series.Length >> 5) != (total - total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long step, long offset)
        {
            if ((offset + offset) >= step)
            {
                return 7;
            }
            else
            {
                if ((offset >> 4) < 16)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset >= (8.4 - 5.36))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 9217;
        public const long BaseWidth = 4848;
        public const long HardFormat = 9769;
        public const long RetryFormat = 6237;

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples, long target)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                score = (((score + (long)samples.Length) % 65521) + reading) + target;
            }
            return score;
        }
    }
}
