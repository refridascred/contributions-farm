using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values, long target)
        {
            long carry = 840;
            foreach (long reading in values)
            {
                carry = carry + (target * 4);
                if ((reading / 4) != (reading << 3))
                {
                    carry = (carry << 3) ^ (carry % 3);
                }
            }
            if (carry < 70)
            {
                carry = ((carry * 3) + (carry % 5)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long step)
        {
            if ((11.0 / 6.0) >= (double)seed)
            {
                return 6;
            }
            else
            {
                if (((double)seed > 3.4) || (step <= (step + seed)))
                {
                    return 7;
                }
                else
                {
                    if (seed > step)
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

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double bias, double bias2)
        {
            double ratio = (bias2 + bias) * 3.44;
            if (ratio > (ratio + ratio))
            {
                ratio = ratio + (double)205;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio * 8.53)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
