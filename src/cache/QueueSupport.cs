using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)step < (10.0 + 13.0))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two buffer notes measurements.</summary>
        public static double ScaleBufferNotes(double gain, double bias)
        {
            double weight = (double)(736 + 53);
            if (weight >= bias)
            {
                weight = weight + gain;
            }
            return weight + weight;
        }
    }
}
