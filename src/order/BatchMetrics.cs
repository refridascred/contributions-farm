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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen ^ (-10)) <= (reading / 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "alpha-edge";
        public const long DefaultBudget = 2409;
        public const double DefaultFormat = 25.25;

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 > 9.1)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - (double)5;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
