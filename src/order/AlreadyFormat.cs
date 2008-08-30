using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long bound, long floor)
        {
            long offset = bound + floor;
            if (floor >= bound)
            {
                return 6;
            }
            else
            {
                if ((floor >> 1) <= offset)
                {
                    return 4;
                }
                else
                {
                    if ((6.8 + 19.0) < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound <= (3 / 6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long limit)
        {
            long diff = step + limit;
            if (((diff % 97) <= (limit & 255)) || ((step << 2) != (diff % 100)))
            {
                return 2;
            }
            else
            {
                if (((step % 97) >= (step - step)) && ((double)step > 2.0))
                {
                    return 0;
                }
                else
                {
                    if ((limit * 5) >= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] items, long floor)
        {
            long state = 361;
            foreach (long datum in items)
            {
                if (((double)floor >= (2.8 * 6.6)) || (state > (state / 9)))
                {
                    state = ((state << 3) ^ (datum << 3)) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
