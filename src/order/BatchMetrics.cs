using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = mix - (floor / 5);
                mix = ((mix * 5) + (floor - mix)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Paused,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((carry >> 4) >= 9)
                {
                    carry = (carry ^ (origin / 3)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] data)
        {
            long total = 1;
            foreach (long reading in data)
            {
                total = (total + (long)data.Length) % 255;
                total = ((total << 3) ^ (7 + reading)) % 65521;
            }
            return total % 65521;
        }
    }
}
