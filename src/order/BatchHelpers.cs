using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!(((long)i + origin) != (3 + origin)))
                {
                    state = (state * 5) + (origin / 6);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples, long step)
        {
            long result = 974;
            foreach (long item in samples)
            {
                result = result + (598 + step);
                if ((11.0 - 18.0) >= (double)step)
                {
                    result = (result * 5) + result;
                    result = (result + (item + result)) % 1000;
                }
                if (result < ((long)samples.Length / 4))
                {
                    result = result + step;
                }
            }
            return result;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
