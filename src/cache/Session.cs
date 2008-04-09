using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long floor)
        {
            long anchor = 34;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 2) + (cell & 127)) - floor;
                if ((double)cell > (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long target, long limit)
        {
            long step = target ^ limit;
            if ((step % 24) != (target + target))
            {
                return 7;
            }
            else
            {
                if ((limit + 0) < (target / 8))
                {
                    return 6;
                }
                else
                {
                    if ((-15) >= (limit - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step < 8) && ((step - target) > (step % 7)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
