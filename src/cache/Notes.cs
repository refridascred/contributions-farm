using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next metric already value from a seed.</summary>
        public static long IterateMetricAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor ^ (42 - target)) % 101;
                if (((long)i / 5) < (anchor / 5))
                {
                    anchor = ((anchor * 4) + (anchor * 2)) % 97;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long step)
        {
            long gap = seed - step;
            if (gap <= (seed % 5))
            {
                return 1;
            }
            else
            {
                if ((seed + step) >= gap)
                {
                    return 8;
                }
                else
                {
                    if ((step % 5) != (seed + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed < (step + gap))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Pending,
            Queued,
            New,
        }
    }
}
