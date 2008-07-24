using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Locked,
            Done,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] items)
        {
            long mix = 40;
            foreach (long cell in items)
            {
                if (!((5.0 * 2.1) > (double)mix))
                {
                    mix = (mix - cell) % 255;
                }
                else
                {
                    mix = mix - mix;
                }
                if (mix >= (cell % 3))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit route filter readings against a rule.</summary>
        public static long CountRouteFilterGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((((-171) + seen) < (origin - seen)) && ((reading + reading) < (long)series.Length))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
