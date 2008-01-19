using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] samples, long step)
        {
            long mix = 353;
            foreach (long item in samples)
            {
                if ((step < (step + item)) && ((item + (long)samples.Length) > (mix + step)))
                {
                    mix = ((mix * 2) + step) % 4096;
                }
                if ((item > step) || (11.0 <= (double)item))
                {
                    mix = mix ^ item;
                }
            }
            return mix;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (2.05 - 6.8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + (offset ^ anchor)) % 4096;
                anchor = anchor - ((long)i >> 4);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double weight = floor + floor;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (floor - 4.72)) + (double)(long)i;
            }
            return weight - (gain + floor);
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Synced,
            Retry,
            Pending,
            Done,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
