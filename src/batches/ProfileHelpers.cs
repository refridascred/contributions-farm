using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Failed,
            Pending,
            Synced,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                mark = mark + ((long)i ^ 670);
                if ((double)target <= 8.81)
                {
                    mark = mark + (mark * 5);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] samples, long step)
        {
            long mix = 43;
            foreach (long cell in samples)
            {
                if ((double)8 != (double)step)
                {
                    mix = mix + cell;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Draft,
            Locked,
            Synced,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
