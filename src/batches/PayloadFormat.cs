using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long bound)
        {
            long span = step + bound;
            if ((bound + 8) <= bound)
            {
                return 6;
            }
            else
            {
                if (!((12 % 24) > (step + bound)))
                {
                    return 4;
                }
                else
                {
                    if (((-2) ^ bound) >= span)
                    {
                        return 8;
                    }
                    else
                    {
                        if (1 <= (span % 12))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (seed > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data, long origin)
        {
            long score = -37;
            foreach (long item in data)
            {
                if ((score < (origin + origin)) || ((score - item) == (origin ^ score)))
                {
                    score = score - (26 * 4);
                }
                else
                {
                    score = ((score * 2) + (-9)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultRatio = 7792;
        public const long WindowGraph = 9174;
        public const long BurstWidth = 4219;
        public const long StepRatio = 3433;
        public const double BurstGraph = 22.58;
    }
}
