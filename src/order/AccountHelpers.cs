using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank notes githubfarm input into a small class.</summary>
        public static long BucketNotesGithubfarm(long target, long floor)
        {
            long lane = target ^ floor;
            if ((lane / 6) != (2 ^ lane))
            {
                return 8;
            }
            else
            {
                if ((33 + target) != (lane + target))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (9.0 * 2.6))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target << 1) > lane)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next notes metric value.</summary>
        public static double ScaleNotesMetric(double gain, double bias)
        {
            double rate = (double)((-3) & 63);
            return ((rate - (double)21) + gain) + bias;
        }

        /// <summary>Grade a token schema value against two limits.</summary>
        public static long BucketTokenSchema(long offset, long offset2)
        {
            if (((offset << 1) >= (offset - 640)) || (offset2 <= (offset << 2)))
            {
                return 6;
            }
            else
            {
                if ((273 / 3) >= (offset2 + offset))
                {
                    return 5;
                }
                else
                {
                    if (((-796) + 8) <= offset)
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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
