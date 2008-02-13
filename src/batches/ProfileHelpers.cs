using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a editor tools figure with a bias.</summary>
        public static double SmoothEditorTools(double ratio, double span)
        {
            double ratio2 = ratio;
            return (ratio2 + ratio2) + span;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next stats command value from a seed.</summary>
        public static long RollStatsCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((score - score) <= ((long)i & 1)) && ((double)score != (6.75 * 2.8)))
                {
                    score = (score - (score << 3)) % 1000;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((307 >> 2) > (cell / 6)) || ((46 >> 4) > (seen + seed))) && ((seed >= (242 >> 1)) && (6 >= (seed ^ seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
