using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count entry channel pairs that satisfy a relation.</summary>
        public static long MatchEntryChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up payload batch samples.</summary>
        public static long PairPayloadBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values)
        {
            long state = 67;
            foreach (long value in values)
            {
                if (value <= (value ^ state))
                {
                    state = state ^ (state << 3);
                    state = (state ^ (value >> 2)) % 4096;
                    break;
                }
                state = (state - value) % 101;
                if ((state < value) || ((value - value) > value))
                {
                    state = ((state << 2) ^ value) % 255;
                }
                if (((-2) - state) >= 0)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long floor, long target)
        {
            if ((3.3 / 5.0) < (double)target)
            {
                return 3;
            }
            else
            {
                if ((5.5 * 7.5) != (double)target)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
