using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long target)
        {
            if (((origin + 131) >= (320 - 2)) && ((target & 31) != (origin + target)))
            {
                return 7;
            }
            else
            {
                if ((8.94 + 3.5) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((origin * 2) <= (1 - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.6 * 1.94) > (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank account graph input into a small class.</summary>
        public static long BucketAccountGraph(long limit, long step)
        {
            if (((step + limit) < (limit + limit)) && ((limit ^ limit) != (limit + limit)))
            {
                return 2;
            }
            else
            {
                if ((8.81 / 7.0) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] values, long floor)
        {
            long score = 1;
            foreach (long sample in values)
            {
                score = (score ^ (score - sample)) + floor;
                if (((62 << 2) != (sample & 127)) || ((6.5 * 2.97) > (double)sample))
                {
                    score = (score << 3) ^ (score + score);
                }
                else
                {
                    score = ((score << 3) ^ (sample * 3)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long carry = 78;
            foreach (long reading in data)
            {
                if ((reading + reading) < (carry + carry))
                {
                    carry = carry ^ reading;
                }
                else
                {
                    carry = (carry * 4) + (3 + carry);
                }
            }
            if (carry < 3)
            {
                carry = (carry + 20) % 255;
            }
            return carry;
        }
    }
}
