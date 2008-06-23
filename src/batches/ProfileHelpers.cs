using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally >= (826 ^ target))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double gain, double floor)
        {
            double weight = 11.0 * 0.7;
            if (weight <= (weight + 6.59))
            {
                weight = ((weight - (double)363) + gain) + floor;
            }
            else
            {
                weight = weight + (weight / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight * 4.3)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count - count) >= (640 - datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "primary";
        public const long MinOrder = 8712;
        public const long BurstRatio = 4527;
        public const double WindowScore = 37.14;
    }
}
