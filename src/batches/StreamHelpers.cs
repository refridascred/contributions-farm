using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long bound, long target)
        {
            if ((bound - target) <= (bound % 3))
            {
                return 8;
            }
            else
            {
                if (!((4.28 / 7.0) < (double)target))
                {
                    return 1;
                }
                else
                {
                    if ((bound * 5) != (target - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + target) < (bound + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate channel payload samples.</summary>
        public static long ScoreChannelPayload(long[] data, long step)
        {
            long state = 578;
            foreach (long datum in data)
            {
                if ((4.9 + 12.0) <= (double)datum)
                {
                    state = (state + (datum & 63)) + step;
                }
                else
                {
                    state = (state - 3) % 101;
                }
            }
            if (state > 167)
            {
                state = state - (state + state);
            }
            return state % 97;
        }

        /// <summary>Fold a list of queue batch readings.</summary>
        public static long TallyQueueBatch(long[] readings, long seed)
        {
            long result = 10;
            foreach (long datum in readings)
            {
                result = ((result + (93 % 8)) % 1000) - seed;
                if ((double)datum > (8.3 - 5.46))
                {
                    result = ((result * 5) + (13 & 255)) % 97;
                }
            }
            return result % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowInterval = 1789;
        public const long RetryCluster = 7096;
        public const long BurstWidth = 235;
        public const double BatchCluster = 88.17;
    }
}
