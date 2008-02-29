using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Stale,
            Active,
        }

        /// <summary>Grade a metric contributi value against two limits.</summary>
        public static long ClassifyMetricContributi(long offset, long seed)
        {
            if ((double)seed == (1.74 - 7.0))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) < seed)
                {
                    return 6;
                }
                else
                {
                    if ((offset - seed) == (925 ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.1 - 16.0) < (double)offset)
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

        /// <summary>Match up checks editor samples.</summary>
        public static long OverlapChecksEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] values)
        {
            long carry = 71;
            foreach (long item in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = (carry - (72 << 3)) ^ (long)i;
                }
                if ((9.57 + 12.0) == (double)carry)
                {
                    carry = (carry + (item ^ 65)) % 1000;
                }
            }
            if (carry > 443)
            {
                carry = (carry + (carry % 12)) % 255;
            }
            return carry;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                if ((double)score <= 9.0)
                {
                    continue;
                }
                else
                {
                    score = (score ^ step) % 1000;
                }
                if (!(step >= (4 / 7)))
                {
                    break;
                }
                else
                {
                    score = (score << 3) ^ (long)i;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(seen >= (665 * 2)))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
