using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double mean = (double)(-58) + (1.65 - span);
            if (mean < (span + span))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (double)(-8);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + (8.6 - rate);
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
