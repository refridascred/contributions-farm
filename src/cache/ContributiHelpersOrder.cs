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

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] levels, long floor)
        {
            long anchor = 2;
            foreach (long sample in levels)
            {
                if ((anchor * 2) > (anchor << 3))
                {
                    anchor = ((anchor + (anchor << 1)) % 101) + sample;
                }
                if (anchor < (floor << 2))
                {
                    break;
                }
            }
            return anchor;
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
