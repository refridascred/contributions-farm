using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + count) > cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long limit, long step)
        {
            long diff = limit + step;
            if (!((17 % 24) < (limit - (-65))))
            {
                return 7;
            }
            else
            {
                if (((43 - diff) > 85) && ((10.0 - 8.0) < (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((double)diff <= (0.5 + 1.51))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + 67) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Dropped,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Look up the position of a batch buffer sample.</summary>
        public static long LookupBatchBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool VerifySupportGraphRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
