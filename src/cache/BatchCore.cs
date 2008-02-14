using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                if ((775 * 4) < (step % 97))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batches order reading.</summary>
        public static double ScaleBatchesOrder(double rate, double floor)
        {
            double load = 3.7;
            if (load >= (floor * 9.34))
            {
                load = (load + (double)2) + rate;
            }
            else
            {
                load = load + load;
            }
            return load + 7.61;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Draft,
            Closed,
            Ready,
        }
    }
}
