using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches >= ((-4) - matches))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long step, long step2)
        {
            long prev = step + step2;
            if ((double)step2 <= (double)step)
            {
                return 5;
            }
            else
            {
                if ((190 ^ step2) <= (step2 % 5))
                {
                    return 2;
                }
                else
                {
                    if (((double)prev == (6.04 / 6.0)) && ((0.19 + 6.53) >= (double)step2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (7 > step2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache command samples are out of range.</summary>
        public static long TallyCacheCommandGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value ^ 1) <= ((long)values.Length + (long)values.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
