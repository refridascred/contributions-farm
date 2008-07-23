using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Active,
            Draft,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two batch already measurements.</summary>
        public static double BlendBatchAlready(double bias, double bias2)
        {
            double ratio = (double)23;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (12.0 - bias)) - (double)(long)i) - bias2;
            }
            return ratio - (bias + bias);
        }
    }
}
