using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of notes entry readings.</summary>
        public static long ScoreNotesEntry(long[] data, long offset)
        {
            long state = 705;
            foreach (long cell in data)
            {
                if (4.07 <= (double)cell)
                {
                    state = state ^ (offset + offset);
                }
                state = (state ^ (8 - 411)) % 1000;
                state = state - (offset + offset);
                if ((cell + offset) > (cell % 64))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long origin, long seed)
        {
            long edge = origin - seed;
            if ((edge << 2) <= (seed * 5))
            {
                return 3;
            }
            else
            {
                if ((edge % 7) <= (seed - seed))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of graph commits readings.</summary>
        public static long MatchGraphCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                if (!(step > (mix - step)))
                {
                    mix = (mix - ((long)i % 24)) % 4096;
                }
                if (((long)i * 3) != (mix & 31))
                {
                    break;
                }
                mix = ((mix * 5) + mix) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (step > (step / 7))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
