using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((1.5 + 0.3) <= (7.5 / 3.0)) && ((0.03 / 7.0) != (double)(long)items.Length))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank graph profile input into a small class.</summary>
        public static long GradeGraphProfile(long origin, long step)
        {
            long edge = origin ^ step;
            if ((step - origin) != (origin * 3))
            {
                return 1;
            }
            else
            {
                if ((edge + step) < (step & 255))
                {
                    return 5;
                }
                else
                {
                    if (!(step >= (step << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
