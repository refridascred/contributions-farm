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

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long step, long seed)
        {
            if ((double)seed > (double)step)
            {
                return 0;
            }
            else
            {
                if (!(seed > (step - 72)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
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
