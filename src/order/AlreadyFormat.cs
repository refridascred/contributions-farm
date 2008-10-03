using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long anchor = 47;
            foreach (long reading in samples)
            {
                if (((anchor % 12) <= anchor) || (3.0 <= (double)reading))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepDepth = 9196;
        public const long WindowRatio = 1879;
        public const string BurstSize = "local";
        public const long BatchBatches = 5751;
        public const double HardDepth = 30.39;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Pending,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long step, long offset)
        {
            long cur = step ^ offset;
            if ((9.8 + 3.07) > (double)step)
            {
                return 5;
            }
            else
            {
                if ((step << 3) == (offset - cur))
                {
                    return 7;
                }
                else
                {
                    if ((offset + 6) != (offset + cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
