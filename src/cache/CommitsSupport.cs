using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a counter route pair into a bucket.</summary>
        public static long BucketCounterRoute(long floor, long target)
        {
            long offset = floor - target;
            if ((offset ^ 9) == (floor + floor))
            {
                return 4;
            }
            else
            {
                if (floor <= 366)
                {
                    return 0;
                }
                else
                {
                    if (((target + target) == (floor ^ target)) && ((740 + floor) > (floor + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((18.0 - 9.0) >= (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series)
        {
            long sum = -630;
            foreach (long sample in series)
            {
                sum = sum + sum;
                sum = sum + sum;
                if (((double)sample == (double)sum) && ((333 ^ 25) != (sample * 4)))
                {
                    break;
                }
            }
            if (sum > (-9))
            {
                sum = (sum ^ (sum << 1)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double rate, double offset)
        {
            double rate2 = rate - rate;
            if (rate2 < (rate2 - rate2))
            {
                rate2 = rate2 + (rate2 + rate);
            }
            else
            {
                rate2 = rate2 - (rate + offset);
            }
            return rate2 - (double)226;
        }
    }
}
