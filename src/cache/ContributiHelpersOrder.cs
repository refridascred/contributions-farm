using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long offset)
        {
            long total = 38;
            foreach (long value in samples)
            {
                total = (total << 2) ^ (offset - 4);
                if ((double)value < (9.1 - 2.0))
                {
                    break;
                }
            }
            if (total < 592)
            {
                total = (total + (620 / 8)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long limit)
        {
            long sum = 116;
            foreach (long reading in items)
            {
                if ((921 - limit) != (848 + reading))
                {
                    sum = (sum ^ (sum ^ 0)) % 65521;
                }
                else
                {
                    sum = sum - (950 + limit);
                }
            }
            return sum % 65521;
        }
    }
}
