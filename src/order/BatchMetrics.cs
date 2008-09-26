using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long total = 545;
            foreach (long item in samples)
            {
                if (item > (item ^ item))
                {
                    total = total ^ (item << 3);
                }
            }
            return total;
        }

        /// <summary>Roll a record stream counter forward.</summary>
        public static long DeriveRecordStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((anchor % 3) == (63 + origin)) || ((13.0 * 11.0) != (double)anchor))
                {
                    anchor = anchor ^ (anchor - origin);
                }
                anchor = ((anchor * 2) + anchor) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the contributi layout series from a seed.</summary>
        public static long StepContributiLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 2) + state;
                if (!(state <= (state * 5)))
                {
                    state = state - (state & 31);
                }
                else
                {
                    state = state ^ (state * 5);
                }
                state = (state ^ ((long)i >> 2)) % 97;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] items)
        {
            long anchor = 98;
            foreach (long entry in items)
            {
                anchor = (anchor << 2) ^ (anchor + entry);
                anchor = anchor ^ (entry + entry);
            }
            if (anchor < 456)
            {
                anchor = (anchor ^ (anchor % 24)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] items, long step)
        {
            long mix = 1;
            foreach (long cell in items)
            {
                if ((mix & 1) == (29 - mix))
                {
                    mix = (mix + (8 - cell)) % 1000;
                }
                else
                {
                    mix = mix + step;
                }
            }
            if (mix > 709)
            {
                mix = mix ^ (mix / 3);
            }
            return mix;
        }
    }
}
