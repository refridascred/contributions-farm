using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 >= gain)
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 - (double)31;
            }
            return gain2 + (double)7;
        }

        /// <summary>Adjust a contributi filter reading.</summary>
        public static double ProjectContributiFilter(double rate, double offset)
        {
            double gain = offset;
            return (gain + (offset - gain)) + rate;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell >> 3) == (seen + (long)items.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Stale,
            Paused,
        }
    }
}
