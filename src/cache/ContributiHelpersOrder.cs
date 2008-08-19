using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit session already readings against a rule.</summary>
        public static long AuditSessionAlreadyHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)(long)items.Length <= (5.6 - 11.0))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double weight = (double)(37 << 3);
            return ((weight - weight) + scale) + offset;
        }

        /// <summary>Iterate the layout command series from a seed.</summary>
        public static long SeriesLayoutCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i + target) != ((long)i & 3))
                {
                    score = score - (target & 63);
                }
                if ((score - score) >= (long)i)
                {
                    score = score + (score - target);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
