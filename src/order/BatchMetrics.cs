using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long origin2)
        {
            if ((origin2 + origin2) < (origin2 / 3))
            {
                return 5;
            }
            else
            {
                if (((origin - origin2) > 52) && ((double)origin == (0.8 - 7.1)))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin2) < origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin2 >> 2) < (0 << 3)) && ((914 * 2) < (origin & 31)))
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

        /// <summary>Combine route schema values into a single score.</summary>
        public static long CombineRouteSchema(long[] readings, long target)
        {
            long state = 43;
            foreach (long entry in readings)
            {
                state = ((state - (52 + state)) % 1000) + entry;
                state = ((state * 3) + (state - target)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] items, long step)
        {
            long carry = 998;
            foreach (long sample in items)
            {
                if (((sample - step) == (carry - sample)) && ((double)carry < (5.75 + 11.0)))
                {
                    carry = carry ^ sample;
                    break;
                }
                else
                {
                    carry = (carry ^ (sample >> 5)) % 255;
                }
                if ((step - step) == (step + carry))
                {
                    carry = (carry ^ (4 / 8)) % 65521;
                }
            }
            return carry;
        }
    }
}
