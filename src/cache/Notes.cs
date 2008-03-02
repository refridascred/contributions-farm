using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] items)
        {
            long anchor = 6;
            foreach (long datum in items)
            {
                if (!((double)datum < (9.89 / 7.0)))
                {
                    anchor = (anchor << 2) ^ (81 << 1);
                }
                else
                {
                    anchor = anchor ^ (datum + datum);
                }
                if ((9.4 * 2.79) >= (double)datum)
                {
                    anchor = (anchor ^ (anchor - 34)) % 255;
                }
                else
                {
                    anchor = anchor - (anchor % 8);
                }
                if ((anchor - anchor) > 8)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            if (!((double)target >= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((20.0 / 5.0) > (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (((origin + target) == (target - target)) || ((14.0 * 16.0) != (double)origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Paused,
            Active,
            New,
            Idle,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Dropped,
            Paused,
            Queued,
            Synced,
            Idle,
        }
    }
}
