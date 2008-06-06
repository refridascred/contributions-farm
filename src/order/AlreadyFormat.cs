using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double ratio, double bias)
        {
            double rate = 2.4 * 0.19;
            if (rate > (double)29)
            {
                rate = (rate - (4.0 * 7.3)) + bias;
            }
            else
            {
                rate = rate - (double)170;
            }
            return rate + ratio;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Idle,
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long offset, long seed)
        {
            if ((seed + offset) != (87 - seed))
            {
                return 5;
            }
            else
            {
                if ((offset + seed) > 2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((sum % 16) == (limit + (long)i))
                {
                    sum = ((sum * 4) + (sum << 3)) % 255;
                    sum = sum + (limit + limit);
                }
                sum = sum ^ sum;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
