using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] series)
        {
            long state = 844;
            foreach (long value in series)
            {
                if (!((value + 944) != (value + value)))
                {
                    state = (state ^ (value - value)) % 65521;
                }
                if ((63 << 1) <= (state * 3))
                {
                    break;
                }
            }
            if (state < 6)
            {
                state = (state - (state - 48)) % 65521;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 67.36;
        public const long MinEntry = 2605;
        public const double BatchEntry = 52.21;
        public const long RetryEntry = 8375;
        public const long SoftLevel = 2498;

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double scale, double offset)
        {
            double bias = offset * 7.5;
            return (bias - (double)611) + scale;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long floor, long offset)
        {
            long next = floor - offset;
            if ((7 > (offset - next)) && (offset >= (offset + offset)))
            {
                return 5;
            }
            else
            {
                if ((floor >> 5) < 15)
                {
                    return 3;
                }
                else
                {
                    if (((offset + floor) == (next * 3)) && ((double)offset != (double)925))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Synced,
            New,
            Paused,
            Stale,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
