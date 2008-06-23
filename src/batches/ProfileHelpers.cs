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

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
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

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6813;
        public const long RetrySize = 6969;
        public const long SoftNotes = 3366;

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

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
