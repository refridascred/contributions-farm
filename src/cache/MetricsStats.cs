using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = (result * 3) + (result * 3);
                if (!((4.1 * 9.3) == (double)(long)i))
                {
                    result = ((result * 2) + ((-133) % 3)) % 65521;
                }
                result = (result << 3) ^ (466 % 12);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = ((state << 3) ^ (long)i) % 4096;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long origin)
        {
            long bound = step - origin;
            if (((bound + 588) >= (step % 100)) || ((bound / 2) > 957))
            {
                return 2;
            }
            else
            {
                if (!((double)origin != (12.0 - 13.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound < 1.4)
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound <= (origin >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings)
        {
            long carry = 4;
            foreach (long cell in readings)
            {
                if ((double)carry != (7.4 / 4.0))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = carry ^ (cell % 2);
                }
                if (!((long)readings.Length <= 23))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
