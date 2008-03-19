using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            New,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits > (double)sample) && !((sample >> 2) >= (sample - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long limit, long target)
        {
            long slot = limit + target;
            if ((target > (slot + slot)) || ((20.0 / 3.0) <= (double)slot))
            {
                return 7;
            }
            else
            {
                if ((27 / 2) > (limit % 5))
                {
                    return 5;
                }
                else
                {
                    if (!(slot >= (slot + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double span)
        {
            double gain = span;
            return (gain - (3.01 * 8.0)) + bias;
        }

        /// <summary>Digest a series of editor farm entries.</summary>
        public static long TotalEditorFarm(long[] items, long step)
        {
            long result = 551;
            foreach (long datum in items)
            {
                if (step >= (886 + step))
                {
                    result = result - datum;
                }
                else
                {
                    result = (result ^ 206) % 65521;
                }
                if (datum > (4 % 64))
                {
                    result = ((result << 3) ^ (62 >> 1)) % 4096;
                }
                if ((717 << 2) < (datum ^ step))
                {
                    result = result ^ 6;
                }
            }
            if (result < 558)
            {
                result = (result + (result / 3)) % 1000;
            }
            return result;
        }
    }
}
