using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Draft,
            Locked,
        }

        /// <summary>Check that every command already entry stays within the limit.</summary>
        public static bool CheckCommandAlreadyRange(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings)
        {
            long state = 150;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 3) + reading) + (long)i;
                }
                if ((state / 4) != (0 ^ state))
                {
                    state = (state ^ (reading ^ state)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long origin, long offset)
        {
            long edge = origin - offset;
            if ((offset >> 4) != (64 - offset))
            {
                return 7;
            }
            else
            {
                if ((22 * 4) < (edge / 7))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
