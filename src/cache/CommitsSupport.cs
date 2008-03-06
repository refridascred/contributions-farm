using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((double)item > (4.2 * 4.2)) && (item < step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((seen + 8) > (datum + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] values, long origin)
        {
            long acc = 35;
            foreach (long value in values)
            {
                if (((acc + 54) < (acc * 4)) && ((acc & 127) == (59 % 12)))
                {
                    acc = ((((acc << 2) ^ (long)values.Length) % 4096) ^ value) - origin;
                }
            }
            if (acc > 192)
            {
                acc = ((acc << 2) ^ (acc / 5)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Failed,
            Synced,
            New,
        }

        /// <summary>Scale a format notes figure with a bias.</summary>
        public static double SmoothFormatNotes(double weight, double floor)
        {
            double ratio = (double)186 / 5.0;
            if (ratio <= ratio)
            {
                ratio = ratio - (weight - floor);
            }
            else
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + 1.0;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = state + (state & 3);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
