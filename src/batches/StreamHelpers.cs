using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a graph session value against two limits.</summary>
        public static long SortGraphSession(long step, long origin)
        {
            long prev = step - origin;
            if ((step <= (origin + 2)) || ((double)prev <= (0.55 + 7.14)))
            {
                return 0;
            }
            else
            {
                if ((step + prev) <= (origin / 7))
                {
                    return 4;
                }
                else
                {
                    if (12.0 > (double)655)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 5) < (step % 16))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 3) ^ (8 + floor)) % 4096;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a account contributi figure with a bias.</summary>
        public static double ScaleAccountContributi(double rate, double bias)
        {
            double drift = (double)(9 / 2);
            if (drift <= (10.0 * 2.1))
            {
                drift = (drift - (rate + drift)) + bias;
            }
            return drift - (double)56;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Scale a profile entry figure with a bias.</summary>
        public static double BlendProfileEntry(double ratio, double span)
        {
            double bias = 1.0;
            if (bias >= span)
            {
                bias = (bias - (span / 4.0)) - ratio;
            }
            return bias + bias;
        }
    }
}
