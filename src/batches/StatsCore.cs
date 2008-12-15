using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long origin)
        {
            long step = floor ^ origin;
            if ((floor + step) <= (origin % 2))
            {
                return 7;
            }
            else
            {
                if ((step << 3) <= (origin * 4))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 3) >= (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) != (step * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "fallback";
        public const long LimitPayload = 1332;
        public const long BurstPayload = 4907;
        public const long MinBudget = 8838;
        public const double StepPayload = 96.75;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((floor & 15) >= (653 + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
