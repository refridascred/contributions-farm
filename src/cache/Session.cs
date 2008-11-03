using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series, long step)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if (!((state % 100) > datum))
                {
                    state = ((state * 4) + ((-502) << 1)) % 97;
                }
                else
                {
                    state = ((state << 2) ^ (datum - datum)) % 1000;
                }
                if (((-187) & 255) != (datum - step))
                {
                    long edge = datum * 4;
                    state = (state - edge) % 97;
                }
                state = (state + (step * 3)) % 4096;
                if ((step << 3) < (step * 5))
                {
                    break;
                }
            }
            if (state > 266)
            {
                state = state - (step * 3);
            }
            return state % 65521;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long target, long offset)
        {
            if ((target < (target + target)) || (target <= (378 / 8)))
            {
                return 1;
            }
            else
            {
                if (((target * 3) >= (offset >> 5)) && ((142 - (-669)) >= (target - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((target / 4) >= (target / 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
