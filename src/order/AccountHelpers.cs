using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Label { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a graph farm counter forward.</summary>
        public static long RollGraphFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                if (!((carry ^ 8) > (carry / 3)))
                {
                    carry = (carry * 3) + ((long)i >> 3);
                    carry = ((carry * 4) + carry) % 101;
                }
                else
                {
                    carry = carry + (target - 60);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long step)
        {
            if (0 < step)
            {
                return 6;
            }
            else
            {
                if ((origin << 3) <= (68 & 63))
                {
                    return 4;
                }
                else
                {
                    if ((step < (step % 60)) && (step >= (step + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin - step) >= (origin & 7)) || ((double)origin >= (11.0 + 1.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (sample <= (tally % 60))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = carry ^ (carry >> 4);
                carry = ((carry << 3) ^ (origin + (long)i)) % 4096;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Locked,
            Paused,
            Done,
        }
    }
}
