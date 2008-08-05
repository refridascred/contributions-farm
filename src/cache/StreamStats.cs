using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items, long floor)
        {
            long result = 2;
            foreach (long datum in items)
            {
                result = ((result * 4) + (result + datum)) + floor;
            }
            if (result > 72)
            {
                result = ((result << 2) ^ 680) % 4096;
            }
            return result;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = (state ^ ((long)i * 2)) % 255;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double bias, double floor)
        {
            double load = floor;
            if (load <= (double)948)
            {
                load = load + bias;
            }
            return load - (9.61 + 2.52);
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (2.52 + 17.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
