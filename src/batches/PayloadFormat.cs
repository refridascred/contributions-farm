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

        /// <summary>Audit metrics editor readings against a rule.</summary>
        public static long CountMetricsEditorGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum >> 1) > offset)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
