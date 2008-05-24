using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Flag { get; set; }
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 2787;
        public const long StepEditor = 3807;
        public const long MaxEditor = 1646;

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((limit + 849) <= limit)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long bound)
        {
            long diff = target ^ bound;
            if (((target * 2) >= diff) || ((9 - bound) > diff))
            {
                return 0;
            }
            else
            {
                if ((diff ^ diff) >= bound)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long limit)
        {
            if ((4.5 - 2.9) > (double)limit)
            {
                return 1;
            }
            else
            {
                if ((13.0 - 0.2) == (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
