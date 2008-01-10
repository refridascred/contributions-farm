using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long bound)
        {
            long anchor = 53;
            foreach (long reading in data)
            {
                if ((reading << 2) != (anchor ^ anchor))
                {
                    anchor = (((anchor << 2) ^ anchor) % 65521) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double bias2)
        {
            double load = bias;
            if (load <= (bias2 + bias))
            {
                load = load + (load / 9.0);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load * 3.1)) - (double)(long)i;
            }
            return load + (load - bias);
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
